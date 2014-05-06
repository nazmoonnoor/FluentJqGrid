using System.Text;
using FluentJqGrid.Core.Edit;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;

namespace FluentJqGrid.ToScript.Edit
{
    internal class ColumnEditRulesToScript:ToScriptBase, IToScript
    {
        private readonly ColumnEditRules _editRules;

        public ColumnEditRulesToScript(ColumnEditRules editRules)
        {
            _editRules = editRules;
        }

        public string ToScript()
        {
            return GetEditRules(_editRules);
        }

        private string GetEditRules(ColumnEditRules editRules)
        {
            if (editRules == null) return string.Empty;
            var sb = new StringBuilder();
            sb.AppendFormat("editrules:{{ ");
            sb.AppendNonNullOrEmpty("edithidden: {0}, ", ToLowerString(editRules.EditHidden));
            sb.AppendNonNullOrEmpty("required: {0}, ", ToLowerString(editRules.Required));
            sb.AppendNonNullOrEmpty("number: {0}, ", ToLowerString(editRules.Number));
            sb.AppendNonNullOrEmpty("integer: {0}, ", ToLowerString(editRules.Integer));
            sb.AppendNonNullOrEmpty("minValue: {0}, ", editRules.MinValue);
            sb.AppendNonNullOrEmpty("maxValue: {0}, ", editRules.MaxValue);
            sb.AppendNonNullOrEmpty("email: {0}, ", ToLowerString(editRules.Email));
            sb.AppendNonNullOrEmpty("url: {0}, ", ToLowerString(editRules.Url));
            sb.AppendNonNullOrEmpty("date: {0}, ", ToLowerString(editRules.Date));
            sb.AppendNonNullOrEmpty("time: {0}, ", ToLowerString(editRules.Time));
            sb.AppendNonNullOrEmpty("custom: {0}, ", ToLowerString(editRules.Custom));
            sb.AppendNonNullOrEmpty("custom_func: {0}, ", editRules.CustomFunction);
            sb.RemoveLast(COMMA);
            sb.AppendFormat("}}, ");
            return sb.ToString();
        }
    }
}