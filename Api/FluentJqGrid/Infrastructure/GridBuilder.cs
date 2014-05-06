using System;
using System.Collections.Generic;
using System.Web.Mvc;
using FluentJqGrid.Core;
using FluentJqGrid.Core.Search;
using FluentJqGrid.Infrastructure.Search;
using FluentJqGrid.ToScript;

namespace FluentJqGrid.Infrastructure
{
    public class GridBuilder<T> : IGridBuilder<T>
    {
        private readonly GridOptions _gridOptions;
        private readonly HtmlHelper<T> _html;
        
        public GridBuilder()
        {
            _gridOptions = new GridOptions();
        }

        public GridBuilder(HtmlHelper<T> html)
        {
            _html = html;
            _gridOptions = new GridOptions();
        }

        public IGridBuilder<T> AjaxGridOptions(string ajaxGridOptions)
        {
            _gridOptions.AjaxGridOptions = ajaxGridOptions;
            return this;
        }

        public IGridBuilder<T> AjaxSelectOptions(string ajaxSelectOptions)
        {
            _gridOptions.AjaxSelectOptions = ajaxSelectOptions;
            return this;
        }

        public IGridBuilder<T> AltClass(string altClass)
        {
            _gridOptions.AltClass = altClass;
            return this;
        }

        public IGridBuilder<T> AltRows(bool altRows)
        {
            _gridOptions.AltRows = altRows;
            return this;
        }

        public IGridBuilder<T> AutoEncode(bool autoEncode)
        {
            _gridOptions.AutoEncode = autoEncode;
            return this;
        }

        public IGridBuilder<T> AutoWidth(bool autoWidth)
        {
            _gridOptions.AutoWidth = autoWidth;
            return this;
        }

        public IGridBuilder<T> Caption(string caption)
        {
            _gridOptions.Caption = caption;
            return this;
        }

        public IGridBuilder<T> CellLayout(int cellLayout)
        {
            _gridOptions.CellLayout = cellLayout;
            return this;
        }

        public IGridBuilder<T> CellEdit(bool cellEdit)
        {
            _gridOptions.CellEdit = cellEdit;
            return this;
        }

        public IGridBuilder<T> CellSubmit(CellSubmitType? cellSubmit)
        {
            _gridOptions.CellSubmit = cellSubmit;
            return this;
        }

        public IGridBuilder<T> CellUrl(string cellUrl)
        {
            _gridOptions.CellUrl = cellUrl;
            return this;
        }

        public IGridBuilder<T> CmTemplate(string cmTemplate)
        {
            _gridOptions.CmTemplate = cmTemplate;
            return this;
        }

        public IGridBuilder<T> Columns(Action<IGridColumnBinder<T>> columns)
        {
            var jqGridColumns = new List<GridColumnOptions>();
            var columnBuilder = new GridColumnBuilder<T>(_html, jqGridColumns);
            columns(columnBuilder);
            _gridOptions.Columns = jqGridColumns;
            columnBuilder.Dispose();
            return this;
        }

        public IGridBuilder<T> Data(string data)
        {
            _gridOptions.Data = data;
            return this;
        }

        public IGridBuilder<T> DataStr(string dataStr)
        {
            _gridOptions.DataStr = dataStr;
            return this;
        }

        public IGridBuilder<T> DataType(string dataType)
        {
            _gridOptions.DataType = dataType;
            return this;
        }

        public IGridBuilder<T> DeepEmpty(bool deepEmpty)
        {
            _gridOptions.DeepEmpty = deepEmpty;
            return this;
        }

        public IGridBuilder<T> DeselectAfterSort(bool deselectAfterSort)
        {
            _gridOptions.DeselectAfterSort = deselectAfterSort;
            return this;
        }

        public IGridBuilder<T> Direction(string direction)
        {
            _gridOptions.Direction = direction;
            return this;
        }

        public IGridBuilder<T> EditUrl(string editUrl)
        {
            _gridOptions.EditUrl = editUrl;
            return this;
        }

        public IGridBuilder<T> EmptyRecords(string emptyRecords)
        {
            _gridOptions.EmptyRecords = emptyRecords;
            return this;
        }

        public IGridBuilder<T> Events(Action<IGridEvents> eventsAction)
        {
            var events = new Events();
            var gridEvents = new GridEvents(events);
            eventsAction(gridEvents);
            _gridOptions.Events = events;
            gridEvents.Dispose();
            return this;
        }

        public IGridBuilder<T> ExpandColClick(bool expandColClick)
        {
            _gridOptions.ExpandColClick = expandColClick;
            return this;
        }

        public IGridBuilder<T> ExpandColumn(string expandColumn)
        {
            _gridOptions.ExpandColumn = expandColumn;
            return this;
        }

        public IGridBuilder<T> FilterToolbar(Action<IFilterToolbar> filterToolbarAction)
        {
            var columnFilterToolbarOptions = new FilterToolbarOptions();
            var filterToolbarOptions = new FilterToolbar(columnFilterToolbarOptions);
            filterToolbarAction(filterToolbarOptions);
            _gridOptions.FilterToolbar = columnFilterToolbarOptions;
            filterToolbarOptions.Dispose();
            return this;
        }

        public IGridBuilder<T> FooterRow(bool footerrow)
        {
            _gridOptions.FooterRow = footerrow;
            return this;
        }

        public IGridBuilder<T> ForceFit(bool forceFit)
        {
            _gridOptions.ForceFit = forceFit;
            return this;
        }

        public IGridBuilder<T> FormEditing(Action<IGridFormEditing> formEditing)
        {
            var formEditingOptions = new FormEditingOptions();
            var gridFormEditing = new GridFormEditing(formEditingOptions);
            formEditing(gridFormEditing);
            _gridOptions.FormEditingOptions = formEditingOptions;
            gridFormEditing.Dispose();
            return this;
        }

        public IGridBuilder<T> GridState(string gridState)
        {
            _gridOptions.GridState = gridState;
            return this;
        }

        public IGridBuilder<T> GridView(bool gridView)
        {
            _gridOptions.GridView = gridView;
            return this;
        }

        public IGridBuilder<T> Grouping(bool grouping)
        {
            _gridOptions.Grouping = grouping;
            return this;
        }

        public IGridBuilder<T> HeaderTitles(bool headertitles)
        {
            _gridOptions.HeaderTitles = headertitles;
            return this;
        }

        public IGridBuilder<T> Height(string height)
        {
            _gridOptions.Height = height;
            return this;
        }

        public IGridBuilder<T> HiddenGrid(bool hiddenGrid)
        {
            _gridOptions.HiddenGrid = hiddenGrid;
            return this;
        }

        public IGridBuilder<T> HideGrid(bool hideGrid)
        {
            _gridOptions.HideGrid = hideGrid;
            return this;
        }

        public IGridBuilder<T> HoverRows(bool hoverRows)
        {
            _gridOptions.HoverRows = hoverRows;
            return this;
        }

        public IGridBuilder<T> IdPrefix(string idPrefix)
        {
            _gridOptions.IdPrefix = idPrefix;
            return this;
        }

        public IGridBuilder<T> IgnoreCase(bool ignoreCase)
        {
            _gridOptions.IgnoreCase = ignoreCase;
            return this;
        }

        public IGridBuilder<T> ImgPath(string imgPath)
        {
            _gridOptions.ImgPath = imgPath;
            return this;
        }

        public IGridBuilder<T> InlineData(string inlineData)
        {
            _gridOptions.InlineData = inlineData;
            return this;
        }

        public IGridBuilder<T> InlineEditing(Action<IGridInlineEditing> inlineEditing)
        {
            var inlineEditingOptions = new List<InlineEditingOptions>();
            var gridInlineEditing = new GridInlineEditing(inlineEditingOptions);
            inlineEditing(gridInlineEditing);
            _gridOptions.InlineEditingOptions = inlineEditingOptions;
            gridInlineEditing.Dispose();
            return this;
        }

        public IGridBuilder<T> JsonReader(string jsonReader)
        {
            _gridOptions.JsonReader = jsonReader;
            return this;
        }

        public IGridBuilder<T> LastPage(int lastPage)
        {
            _gridOptions.LastPage = lastPage;
            return this;
        }

        public IGridBuilder<T> LastSort(int lastSort)
        {
            _gridOptions.LastSort = lastSort;
            return this;
        }

        public IGridBuilder<T> LoadOnce(bool loadOnce)
        {
            _gridOptions.LoadOnce = loadOnce;
            return this;
        }

        public IGridBuilder<T> LoadText(string loadText)
        {
            _gridOptions.LoadText = loadText;
            return this;
        }

        public IGridBuilder<T> LoadUi(string loadUi)
        {
            _gridOptions.LoadUi = loadUi;
            return this;
        }

        public IGridBuilder<T> MType(string mType)
        {
            _gridOptions.MType = mType;
            return this;
        }

        public IGridBuilder<T> MultiKey(string multiKey)
        {
            _gridOptions.MultiKey = multiKey;
            return this;
        }

        public IGridBuilder<T> MultiBoxOnly(bool multiBoxOnly)
        {
            _gridOptions.MultiBoxOnly = multiBoxOnly;
            return this;
        }

        public IGridBuilder<T> MultiSelect(bool multiSelect)
        {
            _gridOptions.MultiSelect = multiSelect;
            return this;
        }

        public IGridBuilder<T> MultiSelectWidth(int multiSelectWidth)
        {
            _gridOptions.MultiSelectWidth = multiSelectWidth;
            return this;
        }

        public IGridBuilder<T> Navigators(Action<IGridNavigator> navigator)
        {
            var navigatorOptions = new NavigatorOptions();
            var gridNavigator = new GridNavigator(navigatorOptions);
            navigator(gridNavigator);
            _gridOptions.NavigatorOptions = navigatorOptions;
            gridNavigator.Dispose();
            return this;
        }

        public IGridBuilder<T> Page(string page)
        {
            _gridOptions.Page = page;
            return this;
        }

        public IGridBuilder<T> Pager(string pager)
        {
            _gridOptions.Pager = pager;
            return this;
        }

        public IGridBuilder<T> PagerPosition(string pagerPosition)
        {
            _gridOptions.PagerPosition = pagerPosition;
            return this;
        }

        public IGridBuilder<T> PgButtons(bool pgButtons)
        {
            _gridOptions.PgButtons = pgButtons;
            return this;
        }

        public IGridBuilder<T> PgInput(bool pgInput)
        {
            _gridOptions.PgInput = pgInput;
            return this;
        }

        public IGridBuilder<T> PgText(string pgText)
        {
            _gridOptions.PgText = pgText;
            return this;
        }

        public IGridBuilder<T> PrmNames(string prmNames)
        {
            _gridOptions.PrmNames = prmNames;
            return this;
        }

        public IGridBuilder<T> PostData(string postData)
        {
            _gridOptions.PostData = postData;
            return this;
        }

        public IGridBuilder<T> Reccount(int reccount)
        {
            _gridOptions.Reccount = reccount;
            return this;
        }

        public IGridBuilder<T> RecordPosition(string recordPosition)
        {
            _gridOptions.RecordPosition = recordPosition;
            return this;
        }

        public IGridBuilder<T> Records(int records)
        {
            _gridOptions.Records = records;
            return this;
        }

        public IGridBuilder<T> RecordText(string recordText)
        {
            _gridOptions.RecordText = recordText;
            return this;
        }

        public IGridBuilder<T> ResizeClass(string resizeClass)
        {
            _gridOptions.ResizeClass = resizeClass;
            return this;
        }

        public IGridBuilder<T> RowList(int[] rowList)
        {
            _gridOptions.RowList = rowList;
            return this;
        }

        public IGridBuilder<T> RowNumbers(bool rowNumbers)
        {
            _gridOptions.RowNumbers = rowNumbers;
            return this;
        }

        public IGridBuilder<T> RowNum(int rowNum)
        {
            _gridOptions.RowNum = rowNum;
            return this;
        }

        public IGridBuilder<T> RowTotal(int rowTotal)
        {
            _gridOptions.RowTotal = rowTotal;
            return this;
        }

        public IGridBuilder<T> RowNumWidth(int rowNumWidth)
        {
            _gridOptions.RowNumWidth = rowNumWidth;
            return this;
        }

        public IGridBuilder<T> SavedRow(string savedRow)
        {
            _gridOptions.SavedRow = savedRow;
            return this;
        }

        public IGridBuilder<T> Scroll(bool scroll)
        {
            _gridOptions.Scroll = scroll;
            return this;
        }

        public IGridBuilder<T> ScrollOffset(int scrollOffset)
        {
            _gridOptions.ScrollOffset = scrollOffset;
            return this;
        }

        public IGridBuilder<T> ScrollTimeout(int scrollTimeout)
        {
            _gridOptions.ScrollTimeout = scrollTimeout;
            return this;
        }

        public IGridBuilder<T> ScrollRows(bool scrollRows)
        {
            _gridOptions.ScrollRows = scrollRows;
            return this;
        }

        public IGridBuilder<T> SearchGrid(Action<ISearchGrid> searchGridAction)
        {
            var columnSearchGridOptions = new SearchGridOptions();
            var searchGridOptions = new SearchGrid(columnSearchGridOptions);
            searchGridAction(searchGridOptions);
            _gridOptions.SearchGrid = columnSearchGridOptions;
            searchGridOptions.Dispose();
            return this;
        }

        public IGridBuilder<T> SelArrrow(string selArrrow)
        {
            _gridOptions.SelArrrow = selArrrow;
            return this;
        }

        public IGridBuilder<T> SelRow(string selRow)
        {
            _gridOptions.SelRow = selRow;
            return this;
        }

        public IGridBuilder<T> ShrinkToFit(bool shrinkToFit)
        {
            _gridOptions.ShrinkToFit = shrinkToFit;
            return this;
        }

        public IGridBuilder<T> Sortable(bool sortable)
        {
            _gridOptions.Sortable = sortable;
            return this;
        }

        public IGridBuilder<T> SortName(string sortName)
        {
            _gridOptions.SortName = sortName;
            return this;
        }

        public IGridBuilder<T> SortOrder(string sortOrder)
        {
            _gridOptions.SortOrder = sortOrder;
            return this;
        }

        [Obsolete("For future implementation.")]
        public IGridBuilder<T> SubGrid(bool subGrid)
        {
            throw new System.NotImplementedException();
        }

        [Obsolete("For future implementation.")]
        public IGridBuilder<T> SubGridOptions(string subGridOptions)
        {
            throw new System.NotImplementedException();
        }

        [Obsolete("For future implementation.")]
        public IGridBuilder<T> SubGridModel(string subGridModel)
        {
            throw new System.NotImplementedException();
        }

        [Obsolete("For future implementation.")]
        public IGridBuilder<T> SubGridType(string subGridType)
        {
            throw new System.NotImplementedException();
        }

        [Obsolete("For future implementation.")]
        public IGridBuilder<T> SubGridUrl(string subGridUrl)
        {
            throw new System.NotImplementedException();
        }

        [Obsolete("For future implementation.")]
        public IGridBuilder<T> SubGridWidth(int subGridWidth)
        {
            throw new System.NotImplementedException();
        }

        [Obsolete("For future implementation.")]
        public IGridBuilder<T> Toolbar(string toolbar)
        {
            throw new System.NotImplementedException();
        }

        public IGridBuilder<T> TopPager(bool topPager)
        {
            _gridOptions.TopPager = topPager;
            return this;
        }

        public IGridBuilder<T> TotalTime(int totalTime)
        {
            _gridOptions.TotalTime = totalTime;
            return this;
        }

        [Obsolete("For future implementation.")]
        public IGridBuilder<T> TreeDataType(string treeDataType)
        {
            throw new System.NotImplementedException();
        }

        [Obsolete("For future implementation.")]
        public IGridBuilder<T> TreeGrid(bool treeGrid)
        {
            throw new System.NotImplementedException();
        }

        [Obsolete("For future implementation.")]
        public IGridBuilder<T> TreeGridModel(string treeGridModel)
        {
            throw new System.NotImplementedException();
        }

        [Obsolete("For future implementation.")]
        public IGridBuilder<T> TreeIcons(string treeIcons)
        {
            throw new System.NotImplementedException();
        }

        [Obsolete("For future implementation.")]
        public IGridBuilder<T> TreeReader(string treeReader)
        {
            throw new System.NotImplementedException();
        }

        [Obsolete("For future implementation.")]
        public IGridBuilder<T> TreeRootLevel(int treeRootLevel)
        {
            throw new System.NotImplementedException();
        }

        public IGridBuilder<T> Url(string url)
        {
            _gridOptions.Url = url;
            return this;
        }

        public IGridBuilder<T> UserData(string userData)
        {
            _gridOptions.UserData = userData;
            return this;
        }

        public IGridBuilder<T> UserDataOnFooter(bool userDataOnFooter)
        {
            _gridOptions.UserDataOnFooter = userDataOnFooter;
            return this;
        }

        public IGridBuilder<T> ViewRecords(bool viewRecords)
        {
            _gridOptions.ViewRecords = viewRecords;
            return this;
        }

        public IGridBuilder<T> ViewSortCols(string viewSortCols)
        {
            _gridOptions.ViewSortCols = viewSortCols;
            return this;
        }

        public IGridBuilder<T> Width(string width)
        {
            _gridOptions.Width = width;
            return this;
        }

        public IGridBuilder<T> XmlReader(string xmlReader)
        {
            _gridOptions.XmlReader = xmlReader;
            return this;
        }

        public IGridBuilder<T> Name(string name)
        {
            _gridOptions.Name = name;
            return this;
        }

        public MvcHtmlString Render(bool renderGridHtml = false)
        {
            var toScriptManager = new ToScriptManager(_gridOptions, renderGridHtml).ToScript();
            return MvcHtmlString.Create(toScriptManager);
        }
    }
}