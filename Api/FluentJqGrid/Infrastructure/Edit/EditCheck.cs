using FluentJqGrid.Core.Edit;

namespace FluentJqGrid.Infrastructure.Edit
{
    public class EditCheck :IEditCheck
    {
        private readonly ColumnEditOptions _columnEditOptions;

        internal EditCheck(ColumnEditOptions columnEditOptions)
        {
            _columnEditOptions = columnEditOptions;
        }

        public IEditCheck Value(bool isCheckBox)
        {
            _columnEditOptions.Value = isCheckBox;
            return this;
        }

        public IEditCheck DataInit(string dataInit)
        {
            _columnEditOptions.DataInit = dataInit;
            return this;
        }

        public IEditCheck DataEvents(string dataEvents)
        {
            _columnEditOptions.DataEvents = dataEvents;
            return this;
        }

        public IEditCheck DefaultValue(string defaultValue)
        {
            _columnEditOptions.DefaultValue = defaultValue;
            return this;
        }

        public IEditCheck NullIfEmpty(bool nullIfEmpty)
        {
            _columnEditOptions.NullIfEmpty = nullIfEmpty;
            return this;
        }

        public IEditCheck Attributes(string attributes)
        {
            _columnEditOptions.Attributes = attributes;
            return this;
        }
    }
}