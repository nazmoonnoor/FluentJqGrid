using FluentJqGrid.Core.Edit;

namespace FluentJqGrid.Infrastructure.Edit
{
    public class ColumnEdit : IColumnEdit
    {
        private readonly ColumnEditOptions _columnEditOptions;

        internal ColumnEdit(ColumnEditOptions columnEditOptions)
        {
            _columnEditOptions = columnEditOptions;
        }

        public IEditText Text()
        {
            _columnEditOptions.EditType = EditType.Text;
            return new EditText(_columnEditOptions);
        }

        public IEditTextArea TextArea()
        {
            _columnEditOptions.EditType = EditType.TextArea;
            return new EditTextArea(_columnEditOptions);
        }

        public IEditSelect Select()
        {
            _columnEditOptions.EditType = EditType.Select;
            return new EditSelect(_columnEditOptions);
        }

        public IEditCheck CheckBox()
        {
            _columnEditOptions.EditType = EditType.Check;
            return new EditCheck(_columnEditOptions);
        }

        public IEditPassword Password()
        {
            _columnEditOptions.EditType = EditType.Password;
            return new EditPassword(_columnEditOptions);
        }

        public IEditButton Button()
        {
            _columnEditOptions.EditType = EditType.Button;
            return new EditButton(_columnEditOptions);
        }

        public IEditImage Image()
        {
            _columnEditOptions.EditType = EditType.Image;
            return new EditImage(_columnEditOptions);
        }

        public IEditFile File()
        {
            throw new System.NotImplementedException();
        }

        public IEditCustom Custom()
        {
            throw new System.NotImplementedException();
        }
    }
}