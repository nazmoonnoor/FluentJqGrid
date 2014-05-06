using FluentJqGrid.Core;
using FluentJqGrid.Extensions;

namespace FluentJqGrid.Settings
{
    public class JqGridColumnSettings
    {
        public ColumnAlign? Align { get; set; }
        public string CellAttribute { get; set; }
        public string Classes { get; set; }
        public string DateFormat { get; set; }
        public string DefaultValue { get; set; }
        public bool? Editable { get; set; }
        public EditType? EditType { get; set; }
        public string FirstSortOrder { get; set; }
        public bool? Fixed { get; set; }
        public string FormatOptions { get; set; }
        public string Formatter { get; set; }
        public bool? Frozen { get; set; }
        public bool? HideInDialog { get; set; }
        public bool? Hidden { get; set; }
        public string Index { get; set; }
        public string JsonMap { get; set; }
        public bool? Key { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public bool? Resizable { get; set; }
        public bool? Search { get; set; }
        public bool? Sortable { get; set; }
        public ColumnSortType? SortType { get; set; }
        public string SearchType { get; set; }
        public string SUrl { get; set; }
        public string Template { get; set; }
        public bool? TitleOnHover { get; set; }
        public int? Width { get; set; }
        public string XmlMap { get; set; }
        public string UnFormat { get; set; }
        public bool? Viewable { get; set; }
        public string Header { get; set; }
        public string Column { get; set; }

        public EditSettings EditSettings { get; set; }
        public EditRulesSettings EditRulesSettings { get; set; }
        public FormOptionSettings FormOptionSettings { get; set; }
        public SearchOptionSettings SearchOptionSettings { get; set; }

        internal Core.GridColumnOptions ToColumnOption()
        {
            var gridColumnOption = new GridColumnOptions();
            Utils.CopyPropertyValues(this, gridColumnOption);
            if (EditSettings != null)
            {
                gridColumnOption.EditOptions = new FluentJqGrid.Core.Edit.ColumnEditOptions();
                Utils.CopyPropertyValues(EditSettings, gridColumnOption.EditOptions);
            }
            if(EditRulesSettings !=null)
            {
                gridColumnOption.EditRules = new FluentJqGrid.Core.Edit.ColumnEditRules();
                Utils.CopyPropertyValues(EditRulesSettings, gridColumnOption.EditRules);
            }

            if(FormOptionSettings!=null)
            {
                gridColumnOption.FormOptions = new FluentJqGrid.Core.Form.ColumnFormOptions();
                Utils.CopyPropertyValues(FormOptionSettings, gridColumnOption.FormOptions);
            }

            if (SearchOptionSettings != null)
            {
                gridColumnOption.SearchOptions = new FluentJqGrid.Core.Search.ColumnSearchOptions();
                Utils.CopyPropertyValues(SearchOptionSettings, gridColumnOption.SearchOptions);
            }

            return gridColumnOption;
        }


    }

    public class SearchOptionSettings
    {
        public string DataUrl { get; set; }
        public string BuildSelect { get; set; }
        public string DataInit { get; set; }
        public string DataEvents { get; set; }
        public string Attr { get; set; }
        public bool? SearchHidden { get; set; }
        public string Sopt { get; set; }
        public string DefaultValue { get; set; }
        public string Value { get; set; }
    }
}
