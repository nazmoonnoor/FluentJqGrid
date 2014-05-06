using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace FluentJqGrid.Experiments
{
    [Serializable]
    public class rows
    {
        [XmlElement("page")]
        public int page;

        [XmlElement("total")]
        public int total;

        [XmlElement("records")]
        public int records;

        //[XmlElement("row")]
        [XmlIgnore]
        public row[] row;

        public string ToXml()
        {
            try
            {
                var sb = new StringBuilder();
                XmlWriter writer = XmlWriter.Create(sb);

                var xs = new XmlSerializer(typeof(rows));
                xs.Serialize(writer, this);
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    [Serializable]
    public class row
    {
        [XmlAttribute("id")]
        public string id;

        [XmlArrayItem("cell", NestingLevel = 0)]
        public object[] cell;
    }

}