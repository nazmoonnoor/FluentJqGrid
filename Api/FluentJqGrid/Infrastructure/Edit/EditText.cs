using FluentJqGrid.Core.Edit;

namespace FluentJqGrid.Infrastructure.Edit
{
    public class EditText : IEditText
    {
        private readonly ColumnEditOptions _columnEditOptions;

        internal EditText(ColumnEditOptions columnEditOptions)
        {
            _columnEditOptions = columnEditOptions;
        }

        public IEditText Size(int size)
        {
            _columnEditOptions.Size = size;
            return this;
        }

        public IEditText MaxLength(int maxLength)
        {
            _columnEditOptions.MaxLength = maxLength;
            return this;
        }

        public IEditText ReadOnly(bool readOnly)
        {
            _columnEditOptions.ReadOnly = readOnly;
            return this;
        }

        public IEditText DataInit(string dataInit)
        {
            _columnEditOptions.DataInit = dataInit;
            return this;
        }

        public IEditText DataEvents(string dataEvents)
        {
            _columnEditOptions.DataEvents = dataEvents;
            return this;
        }

        public IEditText DefaultValue(string defaultValue)
        {
            _columnEditOptions.DefaultValue = defaultValue;
            return this;
        }

        public IEditText NullIfEmpty(bool nullIfEmpty)
        {
            _columnEditOptions.NullIfEmpty = nullIfEmpty;
            return this;
        }

        public IEditText Attributes(string attributes)
        {
            _columnEditOptions.Attributes = attributes;
            return this;
        }
    }
}