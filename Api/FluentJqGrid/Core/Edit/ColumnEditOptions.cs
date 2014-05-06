using System.Collections.Generic;

namespace FluentJqGrid.Core.Edit
{
    internal class ColumnEditOptions
    {
        internal EditType EditType { get; set; }
        internal bool? ReadOnly { get; set; }
        internal int? Size { get; set; }
        internal int? MaxLength { get; set; }
        internal bool? CheckBoxValue { get; set; }
        internal Dictionary<string, string> SelectValues { get; set; }
        internal int? Rows { get; set; }
        internal int? Cols { get; set; }
        internal string ButtonValue { get; set; }
        internal string ImageSrc { get; set; }
        internal dynamic Value { get; set; }
        internal string Attributes { get; set; }

        internal string DataUrl { get; set; }
        internal string BuildSelect { get; set; }
        internal string DataInit { get; set; }
        internal string DataEvents { get; set; }
        internal string DefaultValue { get; set; }
        internal bool? NullIfEmpty { get; set; }
    }
}