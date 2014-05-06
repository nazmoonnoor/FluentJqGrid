using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentJqGrid.ToScript
{
    internal abstract class ToScriptBase
    {
        protected const string SCRIPT_TAG = "<script language=\"javascript\" type=\"text/javascript\">{0}</script>";
        protected const string COMMA = ",";
        protected int PadLeftTo = 6;

        /// <summary>
        /// Shorts for AddSingleQuote :lol:
        /// </summary>
        /// <param name="value">String value that needs to surround with Quote</param>
        /// <returns></returns>
        protected string Asq(string value)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;
            return "'" + value + "'";
        }

        protected string ToLowerString(bool? value)
        {
            return (value != null) ? value.ToString().ToLower() : string.Empty;
        }

        protected string GetRowList(IEnumerable<int> rowList)
        {
            if (rowList == null) return string.Empty;
            string val = rowList.Aggregate(string.Empty, (current, row) => current + (row.ToString() + ","));
            if (val.EndsWith(",")) val = val.Remove(val.LastIndexOf(','));
            return "[" + val + "]";
        }

        protected string Spacing(int val)
        {
            return new string(' ', val);
        }

        protected string NewLine(int spacing)
        {
            return Environment.NewLine + Spacing(spacing);
        }

        public string GetAlignValue(ColumnAlign? align)
        {
            switch (align)
            {
                case ColumnAlign.Left:
                    return "left";
                case ColumnAlign.Center:
                    return "center";
                case ColumnAlign.Right:
                    return "right";
                default:
                    return string.Empty;
            }
        }

        public string GetColumnSortTypeValue(ColumnSortType? editType)
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

        public string GetCellSumbitType(CellSubmitType? cellSubmitType)
        {
            switch (cellSubmitType)
            {
                case CellSubmitType.Remote:
                    return "remote";
                case CellSubmitType.ClientArray:
                    return "clientArray";
                default:
                    return string.Empty;
            }
        }
    }
}