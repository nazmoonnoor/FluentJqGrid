using FluentJqGrid.Core.Edit;

namespace FluentJqGrid.Infrastructure.Edit
{
    public class EditTextArea : IEditTextArea
    {
        private readonly ColumnEditOptions _columnEditOptions;

        internal EditTextArea(ColumnEditOptions columnEditOptions)
        {
            _columnEditOptions = columnEditOptions;
        }

        public IEditTextArea Rows(int rows)
        {
            _columnEditOptions.Rows = rows;
            return this;
        }

        public IEditTextArea Cols(int cols)
        {
            _columnEditOptions.Cols = cols;
            return this;
        }

        public IEditTextArea DataInit(string dataInit)
        {
            _columnEditOptions.DataInit = dataInit;
            return this;
        }

        public IEditTextArea DataEvents(string dataEvents)
        {
            _columnEditOptions.DataEvents = dataEvents;
            return this;
        }

        public IEditTextArea DefaultValue(string defaultValue)
        {
            _columnEditOptions.DefaultValue = defaultValue;
            return this;
        }

        public IEditTextArea NullIfEmpty(bool nullIfEmpty)
        {
            _columnEditOptions.NullIfEmpty = nullIfEmpty;
            return this;
        }
        public IEditTextArea Attributes(string attributes)
        {
            _columnEditOptions.Attributes = attributes;
            return this;
        }
    }
}