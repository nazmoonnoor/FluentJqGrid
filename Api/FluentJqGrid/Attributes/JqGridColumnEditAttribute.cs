using System;
using System.Web.Mvc;

namespace FluentJqGrid.Attributes
{
    public class JqGridColumnEditAttribute : Attribute, IMetadataAware
    {
        public string Editable2 { get; set; }
        public void OnMetadataCreated(ModelMetadata metadata)
        {
            SetAddtionalValue(metadata, "Editable2", Editable2);
        }

        private void SetAddtionalValue(ModelMetadata metadata, string key, object value)
        {
            if (value != null)
            {
                metadata.AdditionalValues[key] = value;
            }
        }
    }
}
