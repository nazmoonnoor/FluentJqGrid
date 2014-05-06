using System.Text;
using FluentJqGrid.Core.Form;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;

namespace FluentJqGrid.ToScript.Form
{
    internal class FormViewToScript : ToScriptBase, IToScript
    {
        private readonly FormViewOptions _formView;

        internal FormViewToScript(FormViewOptions formView)
        {
            _formView = formView;
        }

        public string ToScript()
        {
            return AccumulateFormViewOptions(_formView);
        }

        private string AccumulateFormViewOptions(FormViewOptions formView)
        {
            if (formView == null) return NewLine(6) + "{}";
            var sb = new StringBuilder();
            sb.AppendLine().PadLeft(6);
            sb.Append("{");
            //properties
            sb.AppendNonNullOrEmpty("top: {0}, ", formView.Top);
            sb.AppendNonNullOrEmpty("left: {0}, ", formView.Left);
            sb.AppendNonNullOrEmpty("width: {0}, ", formView.Width);
            sb.AppendNonNullOrEmpty("height: {0}, ", formView.Height);
            sb.AppendNonNullOrEmpty("dataheight: {0}, ", formView.DataHeight);
            sb.AppendNonNullOrEmpty("modal: {0}, ", ToLowerString(formView.Modal));
            sb.AppendNonNullOrEmpty("drag: {0}, ", ToLowerString(formView.Drag));
            sb.AppendNonNullOrEmpty("resize: {0}, ", ToLowerString(formView.Resize));
            sb.AppendNonNullOrEmpty("jqModal: {0}, ", ToLowerString(formView.JqModal));
            sb.AppendNonNullOrEmpty("topinfo: {0}, ", Asq(formView.TopInfo));
            sb.AppendNonNullOrEmpty("bottominfo: {0}, ", Asq(formView.BottomInfo));
            sb.AppendNonNullOrEmpty("closeicon: {0}, ", Asq(formView.CloseIcon));
            sb.AppendNonNullOrEmpty("navkeys: {0}, ", formView.NavKeys);
            sb.AppendNonNullOrEmpty("closeOnEscape: {0}, ", ToLowerString(formView.CloseOnEscape));
            sb.AppendNonNullOrEmpty("viewPagerButtons: {0}, ", ToLowerString(formView.ViewPagerButtons));
            sb.AppendNonNullOrEmpty("labelswidth: {0}, ", Asq(formView.LabelsWidth));
            sb.AppendNonNullOrEmpty("zIndex: {0}, ", formView.ZIndex);
            //events
            sb.AppendNonNullOrEmpty("beforeShowForm: {0}, ", formView.BeforeShowForm);
            sb.AppendNonNullOrEmpty("onClose: {0}, ", formView.OnClose);

            sb.RemoveLast(COMMA);
            sb.Append("}");
            return sb.ToString();
        }
    }
}