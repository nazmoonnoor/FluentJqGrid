namespace FluentJqGrid.Core
{
    internal class InlineEditingOptions
    {
        internal InlineEditTypes InlineEditType { get; set; }
        internal string Keys { get; set; }
        internal string InitData { get; set; }
        internal string Position { get; set; }
        internal string Url { get; set; }
        internal string ExtraParam { get; set; }
        internal bool? UseDefValues { get; set; }
        internal bool? UseFormatter { get; set; }
        internal string AddRowParams { get; set; }
        internal string OnEditFunc { get; set; }
        internal string SuccessFunc { get; set; }
        internal string AfterSaveFunc { get; set; }
        internal string ErrorFunc { get; set; }
        internal string AfterRestoreFunc { get; set; }

        internal string AddRowButtonId { get; set; }
        internal string EditRowButtonId { get; set; }
        internal string SaveRowButtonId { get; set; }
        internal string RestoreRowButtonId { get; set; }
    }

    internal enum InlineEditTypes
    {
        AddRow,
        EditRow,
        SaveRow,
        RestoreRow
    }
}