using System;
using System.Web.Mvc;

namespace FluentJqGrid.Attributes
{
    public class JqGridColumnAttribute : Attribute, IMetadataAware
    {

        public ColumnAlign? Align { get; set; }
        public string CellAttribute { get; set; }
        public string Classes { get; set; }
        public string DateFormat { get; set; }
        public string DefaultValue { get; set; }
        
        
        public string Header { get; set; }
        public string Name { get; set; }
        public string Index { get; set; }
        public int? Width { get; set; }
        public bool? Editable { get; set; }
        public bool? Sortable { get; set; }
        public EditType? EditType { get; set; }
        public ColumnSortType? SortType { get; set; }

        public void OnMetadataCreated(ModelMetadata metadata)
        {
            SetAddtionalValue(metadata, "Align", Align);
            SetAddtionalValue(metadata, "CellAttribute", CellAttribute);
            SetAddtionalValue(metadata, "Classes", Classes);
            SetAddtionalValue(metadata, "DateFormat", DateFormat);
            SetAddtionalValue(metadata, "DefaultValue", DefaultValue);
            
            SetAddtionalValue(metadata, "Header", Header);
            SetAddtionalValue(metadata, "Name", Name);
            SetAddtionalValue(metadata, "Index", Index);
            SetAddtionalValue(metadata, "Width", Width);
            SetAddtionalValue(metadata, "Editable", Editable);
            SetAddtionalValue(metadata, "Sortable", Sortable);
            SetAddtionalValue(metadata, "EditType", EditType);
            SetAddtionalValue(metadata, "SortType", SortType);
        }

        private void SetAddtionalValue(ModelMetadata metadata, string key, object value)
        {
            if(value!=null)
            {
                metadata.AdditionalValues[key] = value;
            }
        }
    }
}
