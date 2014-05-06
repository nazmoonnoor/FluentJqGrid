using System.Collections.Generic;

namespace FluentJqGrid
{
    public class GridData 
    {
        public int Page;
        public int Total;
        public int Records;
        public List<GridRow> Rows = new List<GridRow>();

        public JqGridData ToData()
        {
            return new JqGridData
                       {
                           page = Page,
                           total = Total,
                           records = Records,
                           rows = ToRows()
                       };
        }

        private List<JqGridRow> ToRows()
        {
            var jqGridRows = new List<JqGridRow>();
            Rows.ForEach(r=>jqGridRows.Add(new JqGridRow
                        {
                            id=r.Id,
                            cell = r.Cell
                        }));
            return jqGridRows;
        }

    }
    public class GridRow
    {
        public string Id;
        public List<object> Cell = new List<object>();
    }
}