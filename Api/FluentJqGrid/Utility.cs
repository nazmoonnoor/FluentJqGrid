using System.Text;

namespace FluentJqGrid
{
    public static class Utility
    {
        public static string GetJqColumnAlignValue(ColumnAlign? align)
        {
            switch (align)
            {
                case ColumnAlign.Left:
                    return "left";
                case ColumnAlign.Middle:
                    return "middle";
                case ColumnAlign.Right:
                    return "right";
                default:
                    return string.Empty;
            }
        }

        public static string GetJqColumnEditTypeValue(EditType? editType)
        {
            switch (editType)
            {
                case EditType.Text:
                    return string.Empty;
                case EditType.Select:
                    return "select";
                case EditType.Check:
                    return "checkbox";
                case EditType.TextArea:
                    return "textarea";
                default:
                    return string.Empty;    
            }
        }

        public static string GetJqColumnSortTypeValue(ColumnSortType? editType)
        {
            switch (editType)
            {
                case ColumnSortType.Int:
                    return "int";
                case ColumnSortType.String:
                    return "string";
                case ColumnSortType.Date:
                    return "date";
                default:
                    return string.Empty;
            }
        }

    }
}
