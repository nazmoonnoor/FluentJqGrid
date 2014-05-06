using System.Text;
using FluentJqGrid.Core.Search;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;

namespace FluentJqGrid.ToScript.Search
{
    internal class FilterToolbarToScript : ToScriptBase, IToScript
    {
        private readonly string _gridName;
        private readonly FilterToolbarOptions _filterToolbar;

        internal FilterToolbarToScript(string gridName, FilterToolbarOptions filterToolbar)
        {
            _gridName = gridName;
            _filterToolbar = filterToolbar;
        }

        public string ToScript()
        {
            if (_filterToolbar == null) return string.Empty;
            var sb = new StringBuilder();
            sb.AppendFormat("$(\"#{0}\").jqGrid('filterToolbar', {{", _gridName)
              .AppendNonNullOrEmpty("autosearch: {0}, ", ToLowerString(_filterToolbar.AutoSearch))
              .AppendNonNullOrEmpty("beforeSearch: {0}, ", _filterToolbar.BeforeSearch)
              .AppendNonNullOrEmpty("afterSearch: {0}, ", _filterToolbar.AfterSearch)
              .AppendNonNullOrEmpty("beforeClear: {0}, ", _filterToolbar.BeforeClear)
              .AppendNonNullOrEmpty("afterClear: {0}, ", _filterToolbar.AfterClear)
              .AppendNonNullOrEmpty("searchOnEnter: {0}, ", ToLowerString(_filterToolbar.SearchOnEnter))
              .AppendNonNullOrEmpty("stringResult: {0}, ", ToLowerString(_filterToolbar.StringResult))
              .AppendNonNullOrEmpty("groupOp: {0}, ", _filterToolbar.GroupOp)
              .AppendNonNullOrEmpty("defaultSearch: {0}, ", _filterToolbar.DefaultSearch)
              .RemoveLast(COMMA)
              .Append("});");
            return sb.ToString();
        }
    }
}