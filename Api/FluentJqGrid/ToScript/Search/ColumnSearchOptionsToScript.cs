using System.Text;
using FluentJqGrid.Core.Search;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;

namespace FluentJqGrid.ToScript.Search
{
    internal class ColumnSearchOptionsToScript : ToScriptBase, IToScript
    {
        private readonly ColumnSearchOptions _searchOptions;

        internal ColumnSearchOptionsToScript(ColumnSearchOptions searchOptions)
        {
            _searchOptions = searchOptions;
        }

        public string ToScript()
        {
            if (_searchOptions == null) return string.Empty;
            var sb = new StringBuilder();
            sb.AppendFormat("searchoptions:{{ ");
            sb.AppendFormat("dataUrl: {0}, ", Asq(_searchOptions.DataUrl));
            sb.AppendFormat("buildSelect: {0}, ", _searchOptions.BuildSelect);
            sb.AppendFormat("dataInit: {0}, ", _searchOptions.DataInit);
            sb.AppendFormat("dataEvents: {0}, ", _searchOptions.DataEvents);
            sb.AppendFormat("attr: {0}, ", _searchOptions.Attr);
            sb.AppendFormat("searchhidden: {0}, ", ToLowerString(_searchOptions.SearchHidden));
            sb.AppendFormat("sopt: {0}, ", _searchOptions.Sopt);
            sb.AppendFormat("defaultValue: {0}, ", Asq(_searchOptions.DefaultValue));
            sb.AppendFormat("value: {0}, ", _searchOptions.Value);

            sb.RemoveLast(COMMA);
            sb.AppendFormat("}}, ");
            return sb.ToString();
        }
    }
}