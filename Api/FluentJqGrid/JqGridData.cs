using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace FluentJqGrid
{
    public class JqGridRow
    {
        public string id;
        public List<object> cell = new List<object>();
    }

    public class JqGridData
    {
        public int page;
        public int total;
        public int records;
        public List<JqGridRow> rows = new List<JqGridRow>();

        public string ToXml()
        {
            Func<List<object>, XElement, XElement> cellAction = (cells, rowEle) =>
                    {
                        foreach (var cell in cells)
                            rowEle.Add(new XElement("cell", cell));
                        return rowEle;
                    };

            Func<List<JqGridRow>, List<XElement>> rowsAction = (rw) =>
                    {
                        var rowElements = new List<XElement>();
                        foreach (var item in rw)
                        {
                            var rowEle = new XElement("row");
                            cellAction(item.cell, rowEle).Add(
                                new XAttribute("id", item.id));
                            rowElements.Add(rowEle);
                        }
                        return rowElements;
                    };

            var doc = new XDocument(
                new XDeclaration("1.0", "utf-8", null),
                new XElement("rows",
                             new XElement("records", records),
                             new XElement("total", total),
                             rowsAction(rows)));
            var sb = new StringBuilder();
            var settings = new XmlWriterSettings {OmitXmlDeclaration = false, Indent = true};
            using (var writer = XmlWriter.Create(sb, settings))
            {
                doc.WriteTo(writer);
            }
            return sb.ToString();
        }
    }
}