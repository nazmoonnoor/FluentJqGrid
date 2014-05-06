namespace FluentJqGrid.Infrastructure.Edit
{
    public interface IColumnEdit
    {
        IEditText Text();
        IEditTextArea TextArea();
        IEditSelect Select();
        IEditCheck CheckBox();
        IEditPassword Password();
        IEditButton Button();
        IEditImage Image();
        IEditFile File();
        IEditCustom Custom();
    }
}