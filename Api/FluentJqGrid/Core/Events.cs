namespace FluentJqGrid.Core
{
    internal class Events
    {
        internal string AfterInsertRow { get; set; }
        internal string BeforeProcessing { get; set; }
        internal string BeforeRequest { get; set; }
        internal string BeforeSelectRow { get; set; }
        internal string GridComplete { get; set; }
        internal string LoadBeforeSend { get; set; }
        internal string LoadComplete { get; set; }
        internal string LoadError { get; set; }
        internal string OnCellSelect { get; set; }
        internal string OnDblClickRow { get; set; }
        internal string OnHeaderClick { get; set; }
        internal string OnPaging { get; set; }
        internal string OnRightClickRow { get; set; }
        internal string OnSelectAll { get; set; }
        internal string OnSelectRow { get; set; }
        internal string OnSortCol { get; set; }
        internal string ResizeStart { get; set; }
        internal string ResizeStop { get; set; }
        internal string SerializeGridData { get; set; }
    }
}