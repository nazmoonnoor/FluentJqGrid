using FluentJqGrid.Core.Edit;

namespace FluentJqGrid.Infrastructure.Edit
{
    public class EditPassword : IEditPassword
    {
        private readonly ColumnEditOptions _columnEditOptions;

        internal EditPassword(ColumnEditOptions columnEditOptions)
        {
            _columnEditOptions = columnEditOptions;
        }

        public IEditPassword Size(int size)
        {
            _columnEditOptions.Size = size;
            return this;
        }

        public IEditPassword MaxLength(int maxLength)
        {
            _columnEditOptions.MaxLength = maxLength;
            return this;
        }

        public IEditPassword ReadOnly(bool readOnly)
        {
            _columnEditOptions.ReadOnly = readOnly;
            return this;
        }

        public IEditPassword DataInit(string dataInit)
        {
            _columnEditOptions.DataInit = dataInit;
            return this;
        }

        public IEditPassword DataEvents(string dataEvents)
        {
            _columnEditOptions.DataEvents = dataEvents;
            return this;
        }

        public IEditPassword DefaultValue(string defaultValue)
        {
            _columnEditOptions.DefaultValue = defaultValue;
            return this;
        }

        public IEditPassword NullIfEmpty(bool nullIfEmpty)
        {
            _columnEditOptions.NullIfEmpty = nullIfEmpty;
            return this;
        }

        public IEditPassword Attributes(string attributes)
        {
            _columnEditOptions.Attributes = attributes;
            return this;
        }
    }
}