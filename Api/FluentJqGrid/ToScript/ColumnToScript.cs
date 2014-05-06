using System.Linq;
using System.Text;
using FluentJqGrid.Core;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;
using FluentJqGrid.ToScript.Edit;
using FluentJqGrid.ToScript.Form;
using FluentJqGrid.ToScript.Search;

namespace FluentJqGrid.ToScript
{
    internal class ColumnToScript : ToScriptBase, IToScript
    {
        private readonly GridOptions _gridOptions;

        public ColumnToScript(GridOptions gridOptions)
        {
            _gridOptions = gridOptions;
        }

        public string ToScript()
        {
            if (_gridOptions.Columns == null) return string.Empty;
            var sb = new StringBuilder();
            string colNames = _gridOptions.Columns.Aggregate(string.Empty, (current, jqGridColumn) => current + Asq(jqGridColumn.Header) + ", ");
            colNames = colNames.Remove(colNames.LastIndexOf(','));
            sb.AppendFormat("colNames: [{0}], {1}", colNames, NewLine(PadLeftTo));

            sb.AppendFormat("colModel: [ {0}", NewLine(9));
            for (int i = 0; i < _gridOptions.Columns.Count; i++)
            {
                var item = _gridOptions.Columns[i];
                sb.AppendFormat("{{ name: {0}, ", Asq(item.Name));
                sb.AppendNonNullOrEmpty("index: {0}, ", Asq(item.Index));
                sb.AppendNonNullOrEmpty("width: {0}, ", item.Width);
                sb.AppendNonNullOrEmpty("align: {0}, ", Asq(GetAlignValue(item.Align)));
                sb.AppendNonNullOrEmpty("editable: {0}, ", ToLowerString(item.Editable));
                sb.Append(new ColumnFormOptionsToScript(item.FormOptions).ToScript());
                sb.AppendNonNullOrEmpty("sortable: {0}, ", ToLowerString(item.Sortable));
                sb.AppendNonNullOrEmpty("sorttype: {0}, ", Asq(GetColumnSortTypeValue(item.SortType)));
                sb.AppendNonNullOrEmpty("firstsortorder: {0}, ", Asq(item.FirstSortOrder));
                sb.AppendNonNullOrEmpty("search: {0}, ", ToLowerString(item.Search));
                sb.Append(new ColumnSearchOptionsToScript(item.SearchOptions).ToScript());
                sb.Append(new ColumnSearchRulesToScript(item.SearchRules).ToScript());
                sb.AppendNonNullOrEmpty("stype: {0}, ", Asq(item.SearchType));
                sb.AppendNonNullOrEmpty("surl: {0}, ", Asq(item.SUrl));
                sb.AppendNonNullOrEmpty("cellattr: {0}, ", item.CellAttribute);
                sb.AppendNonNullOrEmpty("classes: {0}, ", Asq(item.Classes));
                sb.AppendNonNullOrEmpty("datefmt: {0}, ", Asq(item.DateFormat));
                sb.AppendNonNullOrEmpty("defval: {0}, ", Asq(item.DefaultValue));
                sb.AppendNonNullOrEmpty("fixed: {0}, ", ToLowerString(item.Fixed));
                sb.AppendNonNullOrEmpty("formatoptions: {0}, ", item.FormatOptions);
                sb.AppendNonNullOrEmpty("formatter: {0}, ", item.Formatter);
                sb.AppendNonNullOrEmpty("hidedlg: {0}, ", ToLowerString(item.HideInDialog));
                sb.AppendNonNullOrEmpty("hidden: {0}, ", ToLowerString(item.Hidden));
                sb.AppendNonNullOrEmpty("fixed: {0}, ", ToLowerString(item.Fixed));
                sb.AppendNonNullOrEmpty("jsonmap: {0}, ", Asq(item.JsonMap));
                sb.AppendNonNullOrEmpty("key: {0}, ", ToLowerString(item.Key));
                sb.AppendNonNullOrEmpty("label: {0}, ", Asq(item.Label));
                sb.AppendNonNullOrEmpty("resizable: {0}, ", ToLowerString(item.Resizable));
                sb.AppendNonNullOrEmpty("template: {0}, ", item.Template);
                sb.AppendNonNullOrEmpty("title: {0}, ", ToLowerString(item.TitleOnHover));
                sb.AppendNonNullOrEmpty("xmlmap: {0}, ", item.XmlMap);
                sb.AppendNonNullOrEmpty("unformat: {0}, ", item.UnFormat);
                sb.AppendNonNullOrEmpty("viewable: {0}, ", ToLowerString(item.Viewable));
                sb.Append(new ColumnEditToScript(item.EditOptions).ToScript());
                sb.Append(new ColumnEditRulesToScript(item.EditRules).ToScript());

                //Cut off the last comma
                sb.RemoveLast(COMMA);
                sb.Append("}");
                if (i == _gridOptions.Columns.Count - 1) continue;
                sb.AppendFormat(",{0}", NewLine(9));
            }

            sb.AppendFormat("], {0}", NewLine(PadLeftTo));

            return sb.ToString();
        }
    }
}