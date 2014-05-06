namespace FluentJqGrid.Core.Search
{
    internal class ColumnSearchRules
    {
        internal bool? Required { get; set; }
        internal bool? Number { get; set; }
        internal bool? Integer { get; set; }
        internal int? MinValue { get; set; }
        internal int? MaxValue { get; set; }
        internal bool? Email { get; set; }
        internal bool? Url { get; set; }
        internal bool? Date { get; set; }
        internal bool? Time { get; set; }
        internal bool? Custom { get; set; }
        internal string CustomFunc { get; set; }
    }
}