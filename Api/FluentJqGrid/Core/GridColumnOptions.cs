using FluentJqGrid.Core.Edit;
using FluentJqGrid.Core.Form;
using FluentJqGrid.Core.Search;

namespace FluentJqGrid.Core
{
    internal class GridColumnOptions
    {
        internal ColumnAlign? Align { get; set; }
        internal string CellAttribute { get; set; }
        internal string Classes { get; set; }
        internal string DateFormat { get; set; }
        internal string DefaultValue { get; set; }
        internal bool? Editable { get; set; }//
        internal ColumnEditOptions EditOptions { get; set; }
        internal ColumnEditRules EditRules { get; set; }
        internal EditType? EditType { get; set; }
        internal string FirstSortOrder { get; set; }
        internal bool? Fixed { get; set; }
        internal ColumnFormOptions FormOptions { get; set; }
        internal string FormatOptions { get; set; }
        internal string Formatter { get; set; }
        internal bool? Frozen { get; set; }
        internal bool? HideInDialog { get; set; }
        internal bool? Hidden { get; set; }
        internal string Index { get; set; }
        internal string JsonMap { get; set; }
        internal bool? Key { get; set; }
        internal string Label { get; set; }
        internal string Name { get; set; }
        internal bool? Resizable { get; set; }
        internal bool? Search { get; set; }
        internal ColumnSearchOptions SearchOptions { get; set; }
        internal ColumnSearchRules SearchRules { get; set; }
        internal bool? Sortable { get; set; }
        internal ColumnSortType? SortType { get; set; }
        internal string SearchType { get; set; }
        internal string SUrl { get; set; }
        internal string Template { get; set; }
        internal bool? TitleOnHover { get; set; }
        internal int? Width { get; set; }
        internal string XmlMap { get; set; }
        internal string UnFormat { get; set; }
        internal bool? Viewable { get; set; }
        internal string Header { get; set; }
        internal string Column { get; set; }
    }
}