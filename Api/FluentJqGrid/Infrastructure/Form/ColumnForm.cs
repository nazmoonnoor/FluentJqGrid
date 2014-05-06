using FluentJqGrid.Core.Form;

namespace FluentJqGrid.Infrastructure.Form
{
    public class ColumnForm : IColumnForm
    {
        private readonly ColumnFormOptions _columnFormOptions;

        internal ColumnForm(ColumnFormOptions columnFormOptions)
        {
            _columnFormOptions = columnFormOptions;
        }

        public IColumnForm ElementPrefix(string elementPrefix)
        {
            _columnFormOptions.ElementPrefix = elementPrefix;
            return this;
        }

        public IColumnForm ElementSuffix(string elementSuffix)
        {
            _columnFormOptions.ElementSuffix = elementSuffix;
            return this;
        }

        public IColumnForm Label(string label)
        {
            _columnFormOptions.Label = label;
            return this;
        }

        public IColumnForm RowPosition(int rowPosition)
        {
            _columnFormOptions.RowPosition = rowPosition;
            return this;
        }

        public IColumnForm ColumnPosition(int columnPosition)
        {
            _columnFormOptions.ColumnPosition = columnPosition;
            return this;
        }
    }

}