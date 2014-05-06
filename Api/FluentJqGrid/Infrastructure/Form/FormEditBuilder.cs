using FluentJqGrid.Core.Form;

namespace FluentJqGrid.Infrastructure.Form
{
    public class FormEditBuilder : IFormEditBuilder
    {
        private readonly FormEditOptions _formEditOptions;

        internal FormEditBuilder(FormEditOptions formEditOptions)
        {
            _formEditOptions = formEditOptions;
        }

        public IFormEditBuilder Top(int top)
        {
            _formEditOptions.Top = top;
            return this;
        }

        public IFormEditBuilder Left(int left)
        {
            _formEditOptions.Left = left;
            return this;
        }

        public IFormEditBuilder Width(int width)
        {
            _formEditOptions.Width = width;
            return this;
        }

        public IFormEditBuilder Height(int height)
        {
            _formEditOptions.Height = height;
            return this;
        }

        public IFormEditBuilder DataHeight(int dataHeight)
        {
            _formEditOptions.DataHeight = dataHeight;
            return this;
        }

        public IFormEditBuilder Modal(bool modal)
        {
            _formEditOptions.Modal = modal;
            return this;
        }

        public IFormEditBuilder Drag(bool drag)
        {
            _formEditOptions.Drag = drag;
            return this;
        }

        public IFormEditBuilder Resize(bool resize)
        {
            _formEditOptions.Resize = resize;
            return this;
        }

        public IFormEditBuilder Url(string url)
        {
            _formEditOptions.Url = url;
            return this;
        }

        public IFormEditBuilder MType(string mType)
        {
            _formEditOptions.MType = mType;
            return this;
        }

        public IFormEditBuilder EditData(string editData)
        {
            _formEditOptions.EditData = editData;
            return this;
        }

        public IFormEditBuilder RecreateForm(bool recreateForm)
        {
            _formEditOptions.RecreateForm = recreateForm;
            return this;
        }

        public IFormEditBuilder Addedrow(string addedRow)
        {
            _formEditOptions.Addedrow = addedRow;
            return this;
        }

        public IFormEditBuilder TopInfo(string topInfo)
        {
            _formEditOptions.TopInfo = topInfo;
            return this;
        }

        public IFormEditBuilder BottomInfo(string bottomInfo)
        {
            _formEditOptions.BottomInfo = bottomInfo;
            return this;
        }

        public IFormEditBuilder SaveIcon(string saveIcon)
        {
            _formEditOptions.SaveIcon = saveIcon;
            return this;
        }

        public IFormEditBuilder CloseIcon(string closeIcon)
        {
            _formEditOptions.CloseIcon = closeIcon;
            return this;
        }

        public IFormEditBuilder SaveKey(string saveKey)
        {
            _formEditOptions.SaveKey = saveKey;
            return this;
        }

        public IFormEditBuilder NavKeys(string navKey)
        {
            _formEditOptions.NavKeys = navKey;
            return this;
        }

        public IFormEditBuilder AjaxEditOptions(string ajaxEditOption)
        {
            _formEditOptions.AjaxEditOptions = ajaxEditOption;
            return this;
        }

        public IFormEditBuilder ViewPagerButtons(bool viewPagerButtons)
        {
            _formEditOptions.ViewPagerButtons = viewPagerButtons;
            return this;
        }

        public IFormEditBuilder ReloadAfterSubmit(bool reloadAfterSubmit)
        {
            _formEditOptions.ReloadAfterSubmit = reloadAfterSubmit;
            return this;
        }

        public IFormEditBuilder CheckOnSubmit(bool checkOnSubmit)
        {
            _formEditOptions.CheckOnSubmit = checkOnSubmit;
            return this;
        }

        public IFormEditBuilder CheckOnUpdate(bool checkOnUpdate)
        {
            _formEditOptions.CheckOnUpdate = checkOnUpdate;
            return this;
        }

        public IFormEditBuilder CloseAfterAdd(bool closeAfterAdd)
        {
            _formEditOptions.CloseAfterAdd = closeAfterAdd;
            return this;
        }

        public IFormEditBuilder ClearAfterAdd(bool clearAfterAdd)
        {
            _formEditOptions.ClearAfterAdd = clearAfterAdd;
            return this;
        }

        public IFormEditBuilder CloseAfterEdit(bool closeAfterEdit)
        {
            _formEditOptions.CloseAfterEdit = closeAfterEdit;
            return this;
        }

        public IFormEditBuilder JqModal(bool jqModal)
        {
            _formEditOptions.JqModal = jqModal;
            return this;
        }

        public IFormEditBuilder CloseOnEscape(bool closeOnEscape)
        {
            _formEditOptions.CloseOnEscape = closeOnEscape;
            return this;
        }

        public IFormEditBuilder ZIndex(int zIndex)
        {
            _formEditOptions.ZIndex = zIndex;
            return this;
        }

        public IFormEditBuilder AfterClickPgButtons(string afterClickPgButtons)
        {
            _formEditOptions.AfterClickPgButtons = afterClickPgButtons;
            return this;
        }

        public IFormEditBuilder AfterComplete(string afterComplete)
        {
            _formEditOptions.AfterComplete = afterComplete;
            return this;
        }

        public IFormEditBuilder AfterShowForm(string afterShowForm)
        {
            _formEditOptions.AfterShowForm = afterShowForm;
            return this;
        }

        public IFormEditBuilder AfterSubmit(string afterSubmit)
        {
            _formEditOptions.AfterSubmit = afterSubmit;
            return this;
        }

        public IFormEditBuilder BeforeCheckValues(string beforeCheckValues)
        {
            _formEditOptions.BeforeCheckValues = beforeCheckValues;
            return this;
        }

        public IFormEditBuilder BeforeInitData(string beforeInitData)
        {
            _formEditOptions.BeforeInitData = beforeInitData;
            return this;
        }

        public IFormEditBuilder BeforeSubmit(string beforeSubmit)
        {
            _formEditOptions.BeforeSubmit = beforeSubmit;
            return this;
        }

        public IFormEditBuilder OnclickPgButtons(string onClickPgButtons)
        {
            _formEditOptions.OnclickPgButtons = onClickPgButtons;
            return this;
        }

        public IFormEditBuilder OnclickSubmit(string onClickSubmit)
        {
            _formEditOptions.OnclickSubmit = onClickSubmit;
            return this;
        }

        public IFormEditBuilder OnInitializeForm(string onInitializeForm)
        {
            _formEditOptions.OnInitializeForm = onInitializeForm;
            return this;
        }

        public IFormEditBuilder ErrorTextFormat(string errorTextForm)
        {
            _formEditOptions.ErrorTextFormat = errorTextForm;
            return this;
        }

        public IFormEditBuilder SerializeEditData(string serializeEditData)
        {
            _formEditOptions.SerializeEditData = serializeEditData;
            return this;
        }

        public IFormEditBuilder BeforeShowForm(string beforeShowForm)
        {
            _formEditOptions.BeforeShowForm = beforeShowForm;
            return this;
        }

        public IFormEditBuilder OnClose(string onClose)
        {
            _formEditOptions.OnClose = onClose;
            return this;
        }
    }
}