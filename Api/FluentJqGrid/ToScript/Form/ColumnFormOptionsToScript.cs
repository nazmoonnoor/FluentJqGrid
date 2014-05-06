using System.Text;
using FluentJqGrid.Core.Form;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;

namespace FluentJqGrid.ToScript.Form
{
    internal class ColumnFormOptionsToScript :ToScriptBase, IToScript
    {
        private readonly ColumnFormOptions _formOptions;

        public ColumnFormOptionsToScript(ColumnFormOptions formOptions)
        {
            _formOptions = formOptions;
        }

        public string ToScript()
        {
            if (_formOptions == null) return string.Empty;
            var sb = new StringBuilder();
            sb.AppendFormat("formoptions:{{ ");
            sb.AppendFormat("elmprefix: {0}, ", Asq(_formOptions.ElementPrefix));
            sb.AppendFormat("elmsuffix: {0}, ", Asq(_formOptions.ElementSuffix));
            sb.AppendFormat("label: {0}, ", Asq(_formOptions.Label));
            sb.AppendFormat("rowpos: {0}, ", _formOptions.RowPosition);
            sb.AppendFormat("colpos: {0}, ", _formOptions.ColumnPosition);
            
            sb.RemoveLast(COMMA);
            sb.AppendFormat("}}, ");
            return sb.ToString();
        }
    }
}