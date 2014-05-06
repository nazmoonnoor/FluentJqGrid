using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace FluentJqGrid.Experiments
{
    public class SerializeToXml : IXmlSerializable
    {
        private readonly JqGridData _jqGridData;

        public SerializeToXml(JqGridData jqGridData)
        {
            _jqGridData = jqGridData;
        }

        public string ToXmlData()
        {
            return null;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            throw new System.NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("rows");
            writer.WriteElementString("page", _jqGridData.page.ToString());
            writer.WriteElementString("total", _jqGridData.total.ToString());
            writer.WriteElementString("records", _jqGridData.records.ToString());
            
            foreach (var row in _jqGridData.rows)
            {
                writer.WriteStartElement("row");
                writer.WriteAttributeString("id", row.id);
                foreach (var cell in row.cell)
                {
                    writer.WriteElementString("cell", cell.ToString());
                }
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
    }
}