using System.Text;
using FluentJqGrid.Core.Search;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;

namespace FluentJqGrid.ToScript.Search
{
    internal class SearchGridToScript : ToScriptBase, IToScript
    {
        private readonly string _gridName;
        private readonly SearchGridOptions _searchGrid;
        private bool _atNavigator;
        internal SearchGridToScript(SearchGridOptions searchGrid)
        {
            _searchGrid = searchGrid;
            _atNavigator = true;
        }

        internal SearchGridToScript(string gridName, SearchGridOptions searchGrid)
        {
            _gridName = gridName;
            _searchGrid = searchGrid;
        }

        public string ToScript()
        {
            if (_searchGrid == null) return string.Empty;
            var sb = new StringBuilder();
            if (_atNavigator)
                sb.Append("{");
            else
                sb.AppendFormat("$(\"#{0}\").jqGrid('searchGrid', {{", _gridName);

            sb.AppendNonNullOrEmpty("afterShowSearch: {0}, ", _searchGrid.AfterShowSearch)
                .AppendNonNullOrEmpty("beforeShowSearch: {0}, ", _searchGrid.BeforeShowSearch)
                .AppendNonNullOrEmpty("closeAfterSearch: {0}, ", ToLowerString(_searchGrid.CloseAfterSearch))
                .AppendNonNullOrEmpty("closeAfterReset: {0}, ", ToLowerString(_searchGrid.CloseAfterReset))
                .AppendNonNullOrEmpty("drag: {0}, ", ToLowerString(_searchGrid.Drag))
                .AppendNonNullOrEmpty("resize: {0}, ", ToLowerString(_searchGrid.Resize))
                .AppendNonNullOrEmpty("modal: {0}, ", ToLowerString(_searchGrid.Modal))
                .AppendNonNullOrEmpty("width: {0}, ", _searchGrid.Width)
                .AppendNonNullOrEmpty("height: {0}, ", Asq(_searchGrid.Height))
                .AppendNonNullOrEmpty("caption: {0}, ", Asq(_searchGrid.Caption))
                .AppendNonNullOrEmpty("showQuery: {0}, ", ToLowerString(_searchGrid.ShowQuery))
                .AppendNonNullOrEmpty("Find: {0}, ", Asq(_searchGrid.Find))
                .AppendNonNullOrEmpty("multipleSearch: {0}, ", ToLowerString(_searchGrid.MultipleSearch))
                .AppendNonNullOrEmpty("multipleGroup: {0}, ", ToLowerString(_searchGrid.MultipleGroup))
                .AppendNonNullOrEmpty("odata: {0}, ", _searchGrid.OData)
                .AppendNonNullOrEmpty("afterRedraw: {0}, ", _searchGrid.AfterRedraw)
                .AppendNonNullOrEmpty("onSearch: {0}, ", _searchGrid.OnSearch)
                .AppendNonNullOrEmpty("onReset: {0}, ", _searchGrid.OnReset)
                .AppendNonNullOrEmpty("closeOnEscape: {0}, ", ToLowerString(_searchGrid.CloseOnEscape))
                .AppendNonNullOrEmpty("onInitializeSearch: {0}, ", _searchGrid.OnInitializeSearch)
                .AppendNonNullOrEmpty("showOnLoad: {0}, ", ToLowerString(_searchGrid.ShowOnLoad))
                .AppendNonNullOrEmpty("errorcheck: {0}, ", ToLowerString(_searchGrid.Errorcheck))
                .AppendNonNullOrEmpty("Reset: {0}, ", Asq(_searchGrid.Reset))
                .AppendNonNullOrEmpty("sField: {0}, ", Asq(_searchGrid.SField))
                .AppendNonNullOrEmpty("sFilter: {0}, ", Asq(_searchGrid.SFilter))
                .AppendNonNullOrEmpty("sOper: {0}, ", Asq(_searchGrid.SOper))
                .AppendNonNullOrEmpty("sopt: {0}, ", _searchGrid.Sopt)
                .AppendNonNullOrEmpty("sValue: {0}, ", Asq(_searchGrid.SValue))
                .AppendNonNullOrEmpty("overlay: {0}, ", _searchGrid.Overlay)
                .AppendNonNullOrEmpty("layer: {0}, ", Asq(_searchGrid.Layer))
                .AppendNonNullOrEmpty("tmplNames: {0}, ", _searchGrid.TmplNames)
                .AppendNonNullOrEmpty("tmplFilters: {0}, ", _searchGrid.TmplFilters)
                .AppendNonNullOrEmpty("tmplLabel: {0}, ", Asq(_searchGrid.TmplLabel))
                .RemoveLast(COMMA)
                .Append(_atNavigator ? "}" : "});");
            return sb.ToString();
        }
    }
}