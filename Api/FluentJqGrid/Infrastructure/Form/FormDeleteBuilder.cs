using FluentJqGrid.Core.Form;

namespace FluentJqGrid.Infrastructure.Form
{
    public class FormDeleteBuilder : IFormDeleteBuilder
    {
        private readonly FormDeleteOptions _formDeleteOptions;

        internal FormDeleteBuilder(FormDeleteOptions formDeleteOptions)
        {
            _formDeleteOptions = formDeleteOptions;
        }

        public IFormDeleteBuilder Top(int top)
        {
            _formDeleteOptions.Top = top;
            return this;
        }

        public IFormDeleteBuilder Left(int left)
        {
            _formDeleteOptions.Left = left;
            return this;
        }

        public IFormDeleteBuilder Width(int width)
        {
            _formDeleteOptions.Width = width;
            return this;
        }

        public IFormDeleteBuilder Height(int height)
        {
            _formDeleteOptions.Height = height;
            return this;
        }

        public IFormDeleteBuilder DataHeight(int dataHeight)
        {
            _formDeleteOptions.DataHeight = dataHeight;
            return this;
        }

        public IFormDeleteBuilder Modal(bool modal)
        {
            _formDeleteOptions.Modal = modal;
            return this;
        }

        public IFormDeleteBuilder Drag(bool drag)
        {
            _formDeleteOptions.Drag = drag;
            return this;
        }

        public IFormDeleteBuilder Resize(bool resize)
        {
            _formDeleteOptions.Resize = resize;
            return this;
        }

        public IFormDeleteBuilder Url(string url)
        {
            _formDeleteOptions.Url = url;
            return this;
        }

        public IFormDeleteBuilder MType(string mType)
        {
            _formDeleteOptions.MType = mType;
            return this;
        }

        public IFormDeleteBuilder DelData(string delData)
        {
            _formDeleteOptions.DelData = delData;
            return this;
        }

        public IFormDeleteBuilder JqModal(bool jqModal)
        {
            _formDeleteOptions.JqModal = jqModal;
            return this;
        }

        public IFormDeleteBuilder DelIcon(string delIcon)
        {
            _formDeleteOptions.DelIcon = delIcon;
            return this;
        }

        public IFormDeleteBuilder CancelIcon(string cancelIcon)
        {
            _formDeleteOptions.CancelIcon = cancelIcon;
            return this;
        }

        public IFormDeleteBuilder AjaxDelOptions(string ajaxDelOptions)
        {
            _formDeleteOptions.AjaxDelOptions = ajaxDelOptions;
            return this;
        }

        public IFormDeleteBuilder ReloadAfterSubmit(bool reloadAfterSubmit)
        {
            _formDeleteOptions.ReloadAfterSubmit = reloadAfterSubmit;
            return this;
        }

        public IFormDeleteBuilder CloseOnEscape(bool closeOnEscape)
        {
            _formDeleteOptions.CloseOnEscape = closeOnEscape;
            return this;
        }

        public IFormDeleteBuilder ZIndex(int zIndex)
        {
            _formDeleteOptions.ZIndex = zIndex;
            return this;
        }

        public IFormDeleteBuilder AfterComplete(string afterComplete)
        {
            _formDeleteOptions.AfterComplete = afterComplete;
            return this;
        }

        public IFormDeleteBuilder AfterShowForm(string afterShowForm)
        {
            _formDeleteOptions.AfterShowForm = afterShowForm;
            return this;
        }

        public IFormDeleteBuilder AfterSubmit(string afterSubmit)
        {
            _formDeleteOptions.AfterSubmit = afterSubmit;
            return this;
        }

        public IFormDeleteBuilder BeforeSubmit(string beforeSubmit)
        {
            _formDeleteOptions.BeforeSubmit = beforeSubmit;
            return this;
        }

        public IFormDeleteBuilder OnclickSubmit(string onClickSubmit)
        {
            _formDeleteOptions.OnclickSubmit = onClickSubmit;
            return this;
        }

        public IFormDeleteBuilder ErrorTextFormat(string errorTextFormat)
        {
            _formDeleteOptions.ErrorTextFormat = errorTextFormat;
            return this;
        }

        public IFormDeleteBuilder BeforeShowForm(string beforeShowForm)
        {
            _formDeleteOptions.BeforeShowForm = beforeShowForm;
            return this;
        }

        public IFormDeleteBuilder OnClose(string onClose)
        {
            _formDeleteOptions.OnClose = onClose;
            return this;
        }

        public IFormDeleteBuilder SerializeDelData(string serializeDelData)
        {
            _formDeleteOptions.SerializeDelData = serializeDelData;
            return this;
        }
    }
}