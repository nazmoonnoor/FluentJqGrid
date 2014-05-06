using FluentJqGrid.Core.Form;

namespace FluentJqGrid.Infrastructure.Form
{
    public class FormViewBuilder : IFormViewBuilder
    {
        private readonly FormViewOptions _formViewOptions;

        internal FormViewBuilder(FormViewOptions formViewOptions)
        {
            _formViewOptions = formViewOptions;
        }

        public IFormViewBuilder Top(int top)
        {
            _formViewOptions.Top = top;
            return this;
        }

        public IFormViewBuilder Left(int left)
        {
            _formViewOptions.Left = left;
            return this;
        }

        public IFormViewBuilder Width(int width)
        {
            _formViewOptions.Width = width;
            return this;
        }

        public IFormViewBuilder Height(int height)
        {
            _formViewOptions.Height = height;
            return this;
        }

        public IFormViewBuilder DataHeight(int dataHeight)
        {
            _formViewOptions.DataHeight = dataHeight;
            return this;
        }

        public IFormViewBuilder Modal(bool modal)
        {
            _formViewOptions.Modal = modal;
            return this;
        }

        public IFormViewBuilder Drag(bool drag)
        {
            _formViewOptions.Drag = drag;
            return this;
        }

        public IFormViewBuilder Resize(bool resize)
        {
            _formViewOptions.Resize = resize;
            return this;
        }

        public IFormViewBuilder TopInfo(string topInfo)
        {
            _formViewOptions.TopInfo = topInfo;
            return this;
        }

        public IFormViewBuilder BottomInfo(string bottomInfo)
        {
            _formViewOptions.BottomInfo = bottomInfo;
            return this;
        }

        public IFormViewBuilder CloseIcon(string closeIcon)
        {
            _formViewOptions.CloseIcon = closeIcon;
            return this;
        }

        public IFormViewBuilder NavKeys(string navKeys)
        {
            _formViewOptions.NavKeys = navKeys;
            return this;
        }

        public IFormViewBuilder ViewPagerButtons(bool viewPagerButtons)
        {
            _formViewOptions.ViewPagerButtons = viewPagerButtons;
            return this;
        }

        public IFormViewBuilder LabelsWidth(string labelsWidth)
        {
            _formViewOptions.LabelsWidth = labelsWidth;
            return this;
        }

        public IFormViewBuilder JqModal(bool jqModal)
        {
            _formViewOptions.JqModal = jqModal;
            return this;
        }

        public IFormViewBuilder CloseOnEscape(bool closeOnEscape)
        {
            _formViewOptions.CloseOnEscape = closeOnEscape;
            return this;
        }

        public IFormViewBuilder ZIndex(int zIndex)
        {
            _formViewOptions.ZIndex = zIndex;
            return this;
        }

        public IFormViewBuilder OnClose(string onClose)
        {
            _formViewOptions.OnClose = onClose;
            return this;
        }

        public IFormViewBuilder BeforeShowForm(string beforeShowForm)
        {
            _formViewOptions.BeforeShowForm = beforeShowForm;
            return this;
        }
    }
}