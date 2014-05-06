namespace FluentJqGrid.Infrastructure.Form
{
    public interface IFormEditBuilder
    {
        IFormEditBuilder Top(int top);
        IFormEditBuilder Left(int left);
        IFormEditBuilder Width(int width);
        IFormEditBuilder Height(int height);
        IFormEditBuilder DataHeight(int dataHeight);
        IFormEditBuilder Modal(bool modal);
        IFormEditBuilder Drag(bool drag);
        IFormEditBuilder Resize(bool resize);
        IFormEditBuilder Url(string url);
        IFormEditBuilder MType(string mType);
        IFormEditBuilder EditData(string editData);
        IFormEditBuilder RecreateForm(bool recreateForm);
        IFormEditBuilder Addedrow(string addedRow);
        IFormEditBuilder TopInfo(string topInfo);
        IFormEditBuilder BottomInfo(string bottomInfo);
        IFormEditBuilder SaveIcon(string saveIcon);
        IFormEditBuilder CloseIcon(string closeIcon);
        IFormEditBuilder SaveKey(string saveKey);
        IFormEditBuilder NavKeys(string navKey);
        IFormEditBuilder AjaxEditOptions(string ajaxEditOption);
        IFormEditBuilder ViewPagerButtons(bool viewPagerButtons);
        IFormEditBuilder ReloadAfterSubmit(bool reloadAfterSubmit);
        IFormEditBuilder CheckOnSubmit(bool checkOnSubmit);
        IFormEditBuilder CheckOnUpdate(bool checkOnUpdate);
        IFormEditBuilder CloseAfterAdd(bool closeAfterAdd);
        IFormEditBuilder ClearAfterAdd(bool clearAfterAdd);
        IFormEditBuilder CloseAfterEdit(bool closeAfterEdit);
        IFormEditBuilder JqModal(bool jqModal);
        IFormEditBuilder CloseOnEscape(bool closeOnEscape);
        IFormEditBuilder ZIndex(int zIndex);

        IFormEditBuilder AfterClickPgButtons(string afterClickPgButtons);
        IFormEditBuilder AfterComplete(string afterComplete);
        IFormEditBuilder AfterShowForm(string afterShowForm);
        IFormEditBuilder AfterSubmit(string afterSubmit);
        IFormEditBuilder BeforeCheckValues(string beforeCheckValues);
        IFormEditBuilder BeforeInitData(string beforeInitData);
        IFormEditBuilder BeforeSubmit(string beforeSubmit);
        IFormEditBuilder OnclickPgButtons(string onClickPgButtons);
        IFormEditBuilder OnclickSubmit(string onClickSubmit);
        IFormEditBuilder OnInitializeForm(string onInitializeForm);
        IFormEditBuilder ErrorTextFormat(string errorTextForm);
        IFormEditBuilder SerializeEditData(string serializeEditData);
        IFormEditBuilder BeforeShowForm(string beforeShowForm);
        IFormEditBuilder OnClose(string onClose);
    }
}