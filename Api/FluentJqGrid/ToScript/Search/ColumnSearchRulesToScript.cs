using System.Text;
using FluentJqGrid.Core.Search;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;

namespace FluentJqGrid.ToScript.Search
{
    internal class ColumnSearchRulesToScript : ToScriptBase, IToScript
    {
        private readonly ColumnSearchRules _searchRules;

        internal ColumnSearchRulesToScript(ColumnSearchRules searchRules)
        {
            _searchRules = searchRules;
        }

        public string ToScript()
        {
            if (_searchRules == null) return string.Empty;
            var sb = new StringBuilder();
            sb.AppendFormat("searchrules:{{ ");
            sb.AppendFormat("required: {0}, ", ToLowerString(_searchRules.Required));
            sb.AppendFormat("number: {0}, ", ToLowerString(_searchRules.Number));
            sb.AppendFormat("integer: {0}, ", ToLowerString(_searchRules.Integer));
            sb.AppendFormat("minValue: {0}, ", _searchRules.MinValue);
            sb.AppendFormat("maxValue: {0}, ", _searchRules.MaxValue);
            sb.AppendFormat("email: {0}, ", ToLowerString(_searchRules.Email));
            sb.AppendFormat("url: {0}, ", ToLowerString(_searchRules.Url));
            sb.AppendFormat("date: {0}, ", ToLowerString(_searchRules.Date));
            sb.AppendFormat("time: {0}, ", ToLowerString(_searchRules.Time));
            sb.AppendFormat("custom: {0}, ", ToLowerString(_searchRules.Custom));
            sb.AppendFormat("custom_func: {0}, ", _searchRules.CustomFunc);

            sb.RemoveLast(COMMA);
            sb.AppendFormat("}}, ");
            return sb.ToString();
        } 
    }
}