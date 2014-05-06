namespace FluentJqGrid.Infrastructure.Form
{
    public interface IColumnForm
    {
        IColumnForm ElementPrefix(string elementPrefix);
        IColumnForm ElementSuffix(string elementSuffix);
        IColumnForm Label(string label);
        IColumnForm RowPosition(int rowPosition);
        IColumnForm ColumnPosition(int columnPosition);
    }
}