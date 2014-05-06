namespace FluentJqGrid.Infrastructure.Form
{
    public interface IFormDeleteBuilder
    {
        IFormDeleteBuilder Top(int top);
        IFormDeleteBuilder Left(int left);
        IFormDeleteBuilder Width(int width);
        IFormDeleteBuilder Height(int height);
        IFormDeleteBuilder DataHeight(int dataHeight);
        IFormDeleteBuilder Modal(bool modal);
        IFormDeleteBuilder Drag(bool drag);
        IFormDeleteBuilder Resize(bool resize);
        IFormDeleteBuilder Url(string url);
        IFormDeleteBuilder MType(string mType);
        IFormDeleteBuilder DelData(string delData);
        IFormDeleteBuilder JqModal(bool jqModal);
        IFormDeleteBuilder DelIcon(string delIcon);
        IFormDeleteBuilder CancelIcon(string cancelIcon);
        IFormDeleteBuilder AjaxDelOptions(string ajaxDelOptions);
        IFormDeleteBuilder ReloadAfterSubmit(bool reloadAfterSubmit);
        IFormDeleteBuilder CloseOnEscape(bool closeOnEscape);
        IFormDeleteBuilder ZIndex(int zIndex);

        IFormDeleteBuilder AfterComplete(string afterComplete);
        IFormDeleteBuilder AfterShowForm(string afterShowForm);
        IFormDeleteBuilder AfterSubmit(string afterSubmit);
        IFormDeleteBuilder BeforeSubmit(string beforeSubmit);
        IFormDeleteBuilder OnclickSubmit(string onClickSubmit);
        IFormDeleteBuilder ErrorTextFormat(string errorTextFormat);
        IFormDeleteBuilder BeforeShowForm(string beforeShowForm);
        IFormDeleteBuilder OnClose(string onClose);
        IFormDeleteBuilder SerializeDelData(string serializeDelData);
    }
}