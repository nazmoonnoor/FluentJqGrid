using System.Collections.Generic;
using FluentJqGrid.Core.Edit;
using FluentJqGrid.Extensions;

namespace FluentJqGrid.Settings
{
    public class EditSettings
    {
        public EditType EditType { get; set; }
        public bool? ReadOnly { get; set; }
        public int? Size { get; set; }
        public int? MaxLength { get; set; }
        public bool? CheckBoxValue { get; set; }
        public Dictionary<string, string> SelectValues { get; set; }
        public int? Rows { get; set; }
        public int? Cols { get; set; }
        public string ButtonValue { get; set; }
        public string ImageSrc { get; set; }
        public dynamic Value { get; set; }
        public string Attributes { get; set; }

        public string DataUrl { get; set; }
        public string BuildSelect { get; set; }
        public string DataInit { get; set; }
        public string DataEvents { get; set; }
        public string DefaultValue { get; set; }
        public bool? NullIfEmpty { get; set; }
    }
}