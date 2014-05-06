using System.Text;
using FluentJqGrid.Core.Form;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;

namespace FluentJqGrid.ToScript.Form
{
    internal class FormDeleteToScript : ToScriptBase, IToScript
    {
        private readonly FormDeleteOptions _formDelete;

        internal FormDeleteToScript(FormDeleteOptions formDelete)
        {
            _formDelete = formDelete;
        }

        public string ToScript()
        {
            return AccumulateFormDeleteOptions(_formDelete);
        }

        private string AccumulateFormDeleteOptions(FormDeleteOptions formDelete)
        {
            if (formDelete == null) return NewLine(6) + "{}";
            var sb = new StringBuilder();
            sb.AppendLine().PadLeft(6);
            sb.Append("{");
            //properties
            sb.AppendNonNullOrEmpty("top: {0}, ", formDelete.Top);
            sb.AppendNonNullOrEmpty("left: {0}, ", formDelete.Left);
            sb.AppendNonNullOrEmpty("width: {0}, ", formDelete.Width);
            sb.AppendNonNullOrEmpty("height: {0}, ", formDelete.Height);
            sb.AppendNonNullOrEmpty("dataheight: {0}, ", formDelete.DataHeight);
            sb.AppendNonNullOrEmpty("modal: {0}, ", ToLowerString(formDelete.Modal));
            sb.AppendNonNullOrEmpty("drag: {0}, ", ToLowerString(formDelete.Drag));
            sb.AppendNonNullOrEmpty("resize: {0}, ", ToLowerString(formDelete.Resize));
            sb.AppendNonNullOrEmpty("url: {0}, ", Asq(formDelete.Url));
            sb.AppendNonNullOrEmpty("mtype: {0}, ", Asq(formDelete.MType));
            sb.AppendNonNullOrEmpty("delData: {0}, ", Asq(formDelete.DelData));
            sb.AppendNonNullOrEmpty("jqModal: {0}, ", ToLowerString(formDelete.JqModal));
            sb.AppendNonNullOrEmpty("delicon: {0}, ", Asq(formDelete.DelIcon));
            sb.AppendNonNullOrEmpty("cancelicon: {0}, ", Asq(formDelete.CancelIcon));
            sb.AppendNonNullOrEmpty("reloadAfterSubmit: {0}, ", ToLowerString(formDelete.ReloadAfterSubmit));
            sb.AppendNonNullOrEmpty("closeOnEscape: {0}, ", ToLowerString(formDelete.CloseOnEscape));
            sb.AppendNonNullOrEmpty("ajaxDelOptions: {0}, ", Asq(formDelete.AjaxDelOptions));
            sb.AppendNonNullOrEmpty("zIndex: {0}, ", formDelete.ZIndex);
            //events
            sb.AppendNonNullOrEmpty("afterComplete: {0}, ", Asq(formDelete.AfterComplete));
            sb.AppendNonNullOrEmpty("afterShowForm: {0}, ", Asq(formDelete.AfterShowForm));
            sb.AppendNonNullOrEmpty("afterSubmit: {0}, ", Asq(formDelete.AfterSubmit));
            sb.AppendNonNullOrEmpty("beforeShowForm: {0}, ", Asq(formDelete.BeforeShowForm));
            sb.AppendNonNullOrEmpty("beforeSubmit: {0}, ", Asq(formDelete.BeforeSubmit));
            sb.AppendNonNullOrEmpty("onclickSubmit: {0}, ", Asq(formDelete.OnclickSubmit));
            sb.AppendNonNullOrEmpty("onClose: {0}, ", Asq(formDelete.OnClose));
            sb.AppendNonNullOrEmpty("errorTextFormat: {0}, ", Asq(formDelete.ErrorTextFormat));
            sb.AppendNonNullOrEmpty("serializeDelData: {0}, ", Asq(formDelete.SerializeDelData));

            sb.RemoveLast(COMMA);
            sb.Append("}");
            return sb.ToString();
        }
    }
}