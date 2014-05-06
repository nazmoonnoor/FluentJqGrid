namespace FluentJqGrid.Infrastructure.Form
{
    public interface IFormViewBuilder
    {
         IFormViewBuilder Top (int top);
         IFormViewBuilder Left (int left);
         IFormViewBuilder Width (int width);
         IFormViewBuilder Height (int height);
         IFormViewBuilder DataHeight (int dataHeight);
         IFormViewBuilder Modal (bool modal);
         IFormViewBuilder Drag (bool drag);
         IFormViewBuilder Resize (bool resize);
         IFormViewBuilder TopInfo (string topInfo);
         IFormViewBuilder BottomInfo(string bottomInfo);
         IFormViewBuilder CloseIcon(string closeIcon);
         IFormViewBuilder NavKeys(string navKeys);
         IFormViewBuilder ViewPagerButtons (bool viewPagerButtons);
         IFormViewBuilder LabelsWidth (string labelsWidth);
         IFormViewBuilder JqModal (bool jqModal);
         IFormViewBuilder CloseOnEscape (bool closeOnEscape);
         IFormViewBuilder ZIndex (int zIndex);
         
         IFormViewBuilder OnClose(string onClose);
         IFormViewBuilder BeforeShowForm(string beforeShowForm); 
    }
}