using System.Text;
using FluentJqGrid.Core.Form;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;

namespace FluentJqGrid.ToScript.Form
{
    internal class FormEditToScript : ToScriptBase, IToScript
    {
        private readonly FormEditOptions _formEdit;

        internal FormEditToScript(FormEditOptions formEdit)
        {
            _formEdit = formEdit;
        }

        public string ToScript()
        {
            return AccumulateFormAddEditOptions(_formEdit);
        }

        private string AccumulateFormAddEditOptions(FormEditOptions formEdit)
        {

            if (formEdit == null) return NewLine(6) + "{}";
            var sb = new StringBuilder();
            sb.AppendLine().PadLeft(6);
            sb.Append("{");
            //properties
            sb.AppendNonNullOrEmpty("top: {0}, ", formEdit.Top);
            sb.AppendNonNullOrEmpty("left: {0}, ", formEdit.Left);
            sb.AppendNonNullOrEmpty("width: {0}, ", formEdit.Width);
            sb.AppendNonNullOrEmpty("height: {0}, ", formEdit.Height);
            sb.AppendNonNullOrEmpty("dataheight: {0}, ", formEdit.DataHeight);
            sb.AppendNonNullOrEmpty("modal: {0}, ", ToLowerString(formEdit.Modal));
            sb.AppendNonNullOrEmpty("drag: {0}, ", ToLowerString(formEdit.Drag));
            sb.AppendNonNullOrEmpty("resize: {0}, ", ToLowerString(formEdit.Resize));
            sb.AppendNonNullOrEmpty("url: {0}, ", Asq(formEdit.Url));
            sb.AppendNonNullOrEmpty("mtype: {0}, ", Asq(formEdit.MType));
            sb.AppendNonNullOrEmpty("editData: {0}, ", Asq(formEdit.EditData));
            sb.AppendNonNullOrEmpty("recreateForm: {0}, ", ToLowerString(formEdit.RecreateForm));
            sb.AppendNonNullOrEmpty("jqModal: {0}, ", ToLowerString(formEdit.JqModal));
            sb.AppendNonNullOrEmpty("addedrow: {0}, ", Asq(formEdit.Addedrow));
            sb.AppendNonNullOrEmpty("topinfo: {0}, ", Asq(formEdit.TopInfo));
            sb.AppendNonNullOrEmpty("bottominfo: {0}, ", Asq(formEdit.BottomInfo));
            sb.AppendNonNullOrEmpty("saveicon: {0}, ", Asq(formEdit.SaveIcon));
            sb.AppendNonNullOrEmpty("closeicon: {0}, ", Asq(formEdit.CloseIcon));
            sb.AppendNonNullOrEmpty("savekey: {0}, ", formEdit.SaveKey);
            sb.AppendNonNullOrEmpty("navkeys: {0}, ", formEdit.NavKeys);
            sb.AppendNonNullOrEmpty("checkOnSubmit: {0}, ", ToLowerString(formEdit.CheckOnSubmit));
            sb.AppendNonNullOrEmpty("checkOnUpdate: {0}, ", ToLowerString(formEdit.CheckOnUpdate));
            sb.AppendNonNullOrEmpty("closeAfterAdd: {0}, ", ToLowerString(formEdit.CloseAfterAdd));
            sb.AppendNonNullOrEmpty("clearAfterAdd: {0}, ", ToLowerString(formEdit.ClearAfterAdd));
            sb.AppendNonNullOrEmpty("closeAfterEdit: {0}, ", ToLowerString(formEdit.CloseAfterEdit));
            sb.AppendNonNullOrEmpty("reloadAfterSubmit: {0}, ", ToLowerString(formEdit.ReloadAfterSubmit));
            sb.AppendNonNullOrEmpty("closeOnEscape: {0}, ", ToLowerString(formEdit.CloseOnEscape));
            sb.AppendNonNullOrEmpty("ajaxEditOptions: {0}, ", Asq(formEdit.AjaxEditOptions));
            sb.AppendNonNullOrEmpty("viewPagerButtons: {0}, ", ToLowerString(formEdit.ViewPagerButtons));
            sb.AppendNonNullOrEmpty("zIndex: {0}, ", formEdit.ZIndex);
            //events
            sb.AppendNonNullOrEmpty("afterclickPgButtons: {0}, ", formEdit.AfterClickPgButtons);
            sb.AppendNonNullOrEmpty("afterComplete: {0}, ", formEdit.AfterComplete);
            sb.AppendNonNullOrEmpty("afterShowForm: {0}, ", formEdit.AfterShowForm);
            sb.AppendNonNullOrEmpty("afterSubmit: {0}, ", formEdit.AfterSubmit);
            sb.AppendNonNullOrEmpty("beforeCheckValues: {0}, ", formEdit.BeforeCheckValues);
            sb.AppendNonNullOrEmpty("beforeInitData: {0}, ", formEdit.BeforeInitData);
            sb.AppendNonNullOrEmpty("beforeShowForm: {0}, ", formEdit.BeforeShowForm);
            sb.AppendNonNullOrEmpty("beforeSubmit: {0}, ", formEdit.BeforeSubmit);
            sb.AppendNonNullOrEmpty("onclickPgButtons: {0}, ", formEdit.OnclickPgButtons);
            sb.AppendNonNullOrEmpty("onclickSubmit: {0}, ", formEdit.OnclickSubmit);
            sb.AppendNonNullOrEmpty("onInitializeForm: {0}, ", formEdit.OnInitializeForm);
            sb.AppendNonNullOrEmpty("onClose: {0}, ", formEdit.OnClose);
            sb.AppendNonNullOrEmpty("errorTextFormat: {0}, ", formEdit.ErrorTextFormat);
            sb.AppendNonNullOrEmpty("serializeEditData: {0}, ", formEdit.SerializeEditData);

            //Cut off the last comma
            sb.RemoveLast(COMMA);
            sb.Append("}");
            return sb.ToString();
        }
    }
}