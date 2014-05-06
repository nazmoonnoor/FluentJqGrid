using System;
using System.ComponentModel;
using System.Web.Mvc;
using FluentJqGrid.Infrastructure.Search;

namespace FluentJqGrid.Infrastructure
{
    /// <summary>
    /// JqGrid builder interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGridBuilder<T>
    {
        /// <summary>
        /// This option allow to set global ajax settings for the grid when we request data. 
        /// Note that with this option is possible to overwrite all current ajax setting in the grid including the error, complete and beforeSend events.
        /// </summary>
        /// <param name="ajaxGridOptions"></param>
        /// <returns></returns>
        IGridBuilder<T> AjaxGridOptions(string ajaxGridOptions);

        /// <summary>
        /// This option allow to set global ajax settings for the select element when the select is obtained via dataUrl option in editoptions or searchoptions objects
        /// </summary>
        /// <param name="ajaxSelectOptions"></param>
        /// <returns></returns>
        IGridBuilder<T> AjaxSelectOptions(string ajaxSelectOptions);

        /// <summary>
        /// The class that is used for alternate rows. You can construct your own class and replace this value. This option is valid only if altRows options is set to true
        /// </summary>
        /// <param name="altClass"></param>
        /// <returns></returns>
        IGridBuilder<T> AltClass(string altClass);

        /// <summary>
        /// Set a zebra-striped grid
        /// </summary>
        /// <param name="altRows"></param>
        /// <returns></returns>
        IGridBuilder<T> AltRows(bool altRows);

        /// <summary>
        /// When set to true encodes (html encode) the incoming (from server) and posted data (from editing modules). By example < will be converted to &lt;
        /// </summary>
        /// <param name="autoEncode"></param>
        /// <returns></returns>
        IGridBuilder<T> AutoEncode(bool autoEncode);

        /// <summary>
        /// When set to true, the grid width is recalculated automatically to the width of the parent element. This is done only initially when the grid is created. In order to resize the grid when the parent element changes width you should apply custom code and use a setGridWidth method for this purpose
        /// </summary>
        /// <param name="autoWidth"></param>
        /// <returns></returns>
        IGridBuilder<T> AutoWidth(bool autoWidth);

        /// <summary>
        /// Defines the Caption layer for the grid. This caption appears above the Header layer. If the string is empty the caption does not appear.
        /// </summary>
        /// <param name="caption"></param>
        /// <returns></returns>
        IGridBuilder<T> Caption(string caption);

        /// <summary>
        /// This option determines the padding + border width of the cell. Usually this should not be changed, but if custom changes to td element are made in the grid css file this will need to be changed. 
        /// The initial value of 5 means paddingLef⇒2+paddingRight⇒2+borderLeft⇒1=5
        /// </summary>
        /// <param name="cellLayout"></param>
        /// <returns></returns>
        IGridBuilder<T> CellLayout(int cellLayout);

        /// <summary>
        /// Enables (disables) cell editing. When this option is set to true, onSelectRow event can not be used, and hovering is disabled (when mouseover on the rows).
        /// </summary>
        /// <param name="cellEdit"></param>
        /// <returns></returns>
        IGridBuilder<T> CellEdit(bool cellEdit);

        /// <summary>
        /// Determines where the contents of the cell are saved: 'remote' or 'clientArray'.
        /// Determines where the contents of the cell are saved - can have two values: 'remote' or 'clientArray'. 
        /// If remote the content of the cell if anything is changed is immediately saved to the server using the cellurl property, via ajax. The rowid and the cell content are added to the url by default. If you have the “mtype” setting set to post, the key value pears will be send as post variables. For example, if we save the cell named mycell,{id: rowid, mycell: cellvalue} is added to the url. 
        /// If cellsubmit is 'clientArray', no ajax request is made and the content of the changed cell can be obtained via the method getChangedCells or thru a event.
        /// </summary>
        /// <param name="cellSubmit"></param>
        /// <returns></returns>
        IGridBuilder<T> CellSubmit(CellSubmitType? cellSubmit);

        /// <summary>
        /// the url where the cell is to be saved. You need to set this only when you use cellsubmit as 'remote'.
        /// </summary>
        /// <param name="cellUrl"></param>
        /// <returns></returns>
        IGridBuilder<T> CellUrl(string cellUrl);

        /// <summary>
        /// Defines a set of properties which overwrite the default values in column Model. By example if you want to make all columns not sortable, then only one propery here can be writen instead in all columns in column model
        /// </summary>
        /// <param name="cmTemplate"></param>
        /// <returns></returns>
        IGridBuilder<T> CmTemplate(string cmTemplate);

        /// <summary>
        /// Array which describes the parameters of the columns.This is the most important part of the grid.
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        IGridBuilder<T> Columns(Action<IGridColumnBinder<T>> columns);

        /// <summary>
        /// A array that store the local data passed to the grid. You can directly point to this variable in case you want to load a array data. It can replace addRowData method which is slow on relative big data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        IGridBuilder<T> Data(string data);

        /// <summary>
        /// The string of data when datatype parameter is set to xmlstring or jsonstring
        /// </summary>
        /// <param name="dataStr"></param>
        /// <returns></returns>
        IGridBuilder<T> DataStr(string dataStr);

        /// <summary>
        /// Defines what type of information to expect to represent data in the grid. Valid options are xml - we expect xml data; xmlstring - we expect xml data as string; json - we expect JSON data; jsonstring - we expect JSON data as string; local - we expect data defined at client side (array data); javascript - we expect javascript as data; function - custom defined function for retrieving data. 
        /// </summary>
        /// <param name="dataType"></param>
        /// <returns></returns>
        IGridBuilder<T> DataType(string dataType);

        /// <summary>
        /// This option should be set to true if a event or a plugin is attached to the table cell. The option uses jQuery empty for the the row and all its children elements. This have of course speed overhead, but prevent memory leaks
        /// </summary>
        /// <param name="deepEmpty"></param>
        /// <returns></returns>
        IGridBuilder<T> DeepEmpty(bool deepEmpty);

        /// <summary>
        /// Applicable only when we use datatype : local. Deselects currently-selected row(s) when a sort is applied.
        /// </summary>
        /// <param name="deselectAfterSort"></param>
        /// <returns></returns>
        IGridBuilder<T> DeselectAfterSort(bool deselectAfterSort);

        /// <summary>
        /// Determines the language direction in grid. The default is “ltr” (Left To Right language). When set to “rtl” (Right To Left) the grid automatically do the needed. 
        /// It is important to note that in one page we can have two (or more) grids where the one can have direction “ltr” while the other can have direction “rtl”. This option work only in FireFox 3.x versions and Internet Explorer versions >=6. Currently Safai and Google Chrome does not support fully direction “rtl”. Also the same apply to Opera browsers. The most common problem in FireFox is that the default settings of the browser does not support RTL. In order change this see HOW TO section in this chapter .
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        IGridBuilder<T> Direction(string direction);

        /// <summary>
        /// Defines the url for inline and form editing.
        /// </summary>
        /// <param name="editUrl"></param>
        /// <returns></returns>
        IGridBuilder<T> EditUrl(string editUrl);

        /// <summary>
        /// Display the information when the returned (or the current) number of records is zero. This option is valid only if viewrecords option is set to true.
        /// </summary>
        /// <param name="emptyRecords"></param>
        /// <returns></returns>
        IGridBuilder<T> EmptyRecords(string emptyRecords);

        /// <summary>
        /// Add Grid events to the grid
        /// </summary>
        /// <param name="eventsAction"></param>
        /// <returns></returns>
        IGridBuilder<T> Events(Action<IGridEvents> eventsAction);

        /// <summary>
        /// when true, the treeGrid is expanded and/or collapsed when we click on the text of the expanded column, not only on the image.
        /// </summary>
        /// <param name="expandColClick"></param>
        /// <returns></returns>
        IGridBuilder<T> ExpandColClick(bool expandColClick);

        /// <summary>
        /// indicates which column (name from colModel) should be used to expand the tree grid. If not set the first one is used. Valid only when treeGrid option is set to true.
        /// </summary>
        /// <param name="expandColumn"></param>
        /// <returns></returns>
        IGridBuilder<T> ExpandColumn(string expandColumn);

        /// <summary>
        /// Add toolbar searching to the grid
        /// </summary>
        /// <param name="filterToolbarAction"></param>
        /// <returns></returns>
        IGridBuilder<T> FilterToolbar(Action<IFilterToolbar> filterToolbarAction);

        /// <summary>
        /// If set to true this will place a footer table with one row below the gird records and above the pager. The number of columns equal of these from colModel
        /// </summary>
        /// <param name="footerrow"></param>
        /// <returns></returns>
        IGridBuilder<T> FooterRow(bool footerrow);

        /// <summary>
        /// If set to true, and resizing the width of a column, the adjacent column (to the right) will resize so that the overall grid width is maintained (e.g., reducing the width of column 2 by 30px will increase the size of column 3 by 30px). In this case there is no horizontal scrolbar. Note: this option is not compatible with shrinkToFit option - i.e if shrinkToFit is set to false, forceFit is ignored.
        /// </summary>
        /// <param name="forceFit"></param>
        /// <returns></returns>
        IGridBuilder<T> ForceFit(bool forceFit);

        /// <summary>
        /// Initializes form editing options by custom buttons
        /// </summary>
        /// <param name="formEditing"></param>
        /// <returns></returns>
        IGridBuilder<T> FormEditing(Action<IGridFormEditing> formEditing);

        /// <summary>
        /// Determines the current state of the grid (i.e. when used with hiddengrid, hidegrid and caption options). Can have either of two states: 'visible' or 'hidden'
        /// </summary>
        /// <param name="gridState"></param>
        /// <returns></returns>
        IGridBuilder<T> GridState(string gridState);

        /// <summary>
        /// In the previous versions of jqGrid including 3.4.X,reading a relatively big data sets (Rows >=100 ) caused speed problems. The reason for this was that as every cell was inserted into the grid we applied about 5-6 jQuery calls to it. Now this problem is resolved; we now insert the entry row at once with a jQuery append. The result is impressive - about 3-5 times faster. What will be the result if we insert all the data at once? Yes, this can be done with a help of gridview option when set to true. The result is a grid that is 5 to 10 times faster. Of course when this option is set to true we have some limitations. If set to true we can not use treeGrid, subGrid, or afterInsertRow event. If you do not use these three options in the grid you can set this option to true and enjoy the speed
        /// </summary>
        /// <param name="gridView"></param>
        /// <returns></returns>
        IGridBuilder<T> GridView(bool gridView);

        /// <summary>
        /// Enables grouping in grid. Please refer grouping page.
        /// </summary>
        /// <param name="grouping"></param>
        /// <returns></returns>
        IGridBuilder<T> Grouping(bool grouping);

        /// <summary>
        /// If the option is set to true the title attribute is added to the column headers
        /// </summary>
        /// <param name="headertitles"></param>
        /// <returns></returns>
        IGridBuilder<T> HeaderTitles(bool headertitles);

        /// <summary>
        /// The height of the grid. Can be set as number (in this case we mean pixels) or as percentage (only 100% is acceped) or value of auto is acceptable.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        IGridBuilder<T> Height(string height);

        /// <summary>
        /// If set to true the grid initially is hidden. The data is not loaded (no request is sent) and only the caption layer is shown. When the show/hide button is clicked the first time to show grid, the request is sent to the server, the data is loaded, and grid is shown. From this point we have a regular grid. This option has effect only if the caption property is not empty and the hidegrid property (see below) is set to true.
        /// </summary>
        /// <param name="hiddenGrid"></param>
        /// <returns></returns>
        IGridBuilder<T> HiddenGrid(bool hiddenGrid);

        /// <summary>
        /// Enables or disables the show/hide grid button, which appears on the right side of the Caption layer. Takes effect only if the caption property is not an empty string.
        /// </summary>
        /// <param name="hideGrid"></param>
        /// <returns></returns>
        IGridBuilder<T> HideGrid(bool hideGrid);

        /// <summary>
        /// When set to false the mouse hovering is disabled in the grid data rows.
        /// </summary>
        /// <param name="hoverRows"></param>
        /// <returns></returns>
        IGridBuilder<T> HoverRows(bool hoverRows);

        /// <summary>
        /// When set this string is added as prefix to the id of the row when it is build
        /// </summary>
        /// <param name="idPrefix"></param>
        /// <returns></returns>
        IGridBuilder<T> IdPrefix(string idPrefix);

        /// <summary>
        /// By default the local searching is case sensitive. To make the local search and sorting not case sensitive set this options to true
        /// </summary>
        /// <param name="ignoreCase"></param>
        /// <returns></returns>
        IGridBuilder<T> IgnoreCase(bool ignoreCase);

        /// <summary>
        /// Image path
        /// </summary>
        /// <param name="imgPath"></param>
        /// <returns></returns>
        IGridBuilder<T> ImgPath(string imgPath);

        /// <summary>
        /// an array used to add content to the data posted to the server when we are in inline editing.
        /// </summary>
        /// <param name="inlineData"></param>
        /// <returns></returns>
        IGridBuilder<T> InlineData(string inlineData);

        /// <summary>
        /// Initializes inline editing options by custom buttons
        /// </summary>
        /// <param name="inlineEditing"></param>
        /// <returns></returns>
        IGridBuilder<T> InlineEditing(Action<IGridInlineEditing> inlineEditing);

        /// <summary>
        /// Array which describes the structure of the expected json data. For a full description and default setting, see Retrieving Data JSON Data
        /// </summary>
        /// <param name="jsonReader"></param>
        /// <returns></returns>
        IGridBuilder<T> JsonReader(string jsonReader);

        /// <summary>
        /// Readonly property. Determines the total number of pages returned from the request.
        /// </summary>
        /// <param name="lastPage"></param>
        /// <returns></returns>
        IGridBuilder<T> LastPage(int lastPage);

        /// <summary>
        /// Readonly property. Determines the index of last sorted column beginning from 0
        /// </summary>
        /// <param name="lastSort"></param>
        /// <returns></returns>
        IGridBuilder<T> LastSort(int lastSort);

        /// <summary>
        /// If this flag is set to true, the grid loads the data from the server only once (using the appropriate datatype). After the first request the datatype parameter is automatically changed to local and all further manipulations are done on the client side. The functions of the pager (if present) are disabled.
        /// </summary>
        /// <param name="loadOnce"></param>
        /// <returns></returns>
        IGridBuilder<T> LoadOnce(bool loadOnce);

        /// <summary>
        /// The text which appear when requesting and sorting data. This parameter is located in language file
        /// </summary>
        /// <param name="loadText"></param>
        /// <returns></returns>
        IGridBuilder<T> LoadText(string loadText);

        /// <summary>
        /// This option controls what to do when an ajax operation is in progress.
        /// disable - disables the jqGrid progress indicator. This way you can use your own indicator.
        /// enable (default) - enables “Loading” message in the center of the grid. 
        /// block - enables the “Loading” message and blocks all actions in the grid until the ajax request is finished. 
        /// Note that this disables paging, sorting and all actions on toolbar, if any.Note that this 
        /// </summary>
        /// <param name="loadUi"></param>
        /// <returns></returns>
        IGridBuilder<T> LoadUi(string loadUi);

        /// <summary>
        /// Defines the type of request to make (“POST” or “GET”)
        /// </summary>
        /// <param name="mType"></param>
        /// <returns></returns>
        IGridBuilder<T> MType(string mType);

        /// <summary>
        /// This parameter have sense only multiselect option is set to true. Defines the key which will be pressed when we make multiselection. The possible values are: shiftKey - the user should press Shift Key altKey - the user should press Alt Key ctrlKey - the user should press Ctrl Key
        /// </summary>
        /// <param name="multiKey"></param>
        /// <returns></returns>
        IGridBuilder<T> MultiKey(string multiKey);

        /// <summary>
        /// This option works only when multiselect = true. When multiselect is set to true, clicking anywhere on a row selects that row; when multiboxonly is also set to true, the multiselection is done only when the checkbox is clicked (Yahoo style). Clicking in any other row (suppose the checkbox is not clicked) deselects all rows and the current row is selected.
        /// </summary>
        /// <param name="multiBoxOnly"></param>
        /// <returns></returns>
        IGridBuilder<T> MultiBoxOnly(bool multiBoxOnly);

        /// <summary>
        /// If this flag is set to true a multi selection of rows is enabled. A new column at left side is added. Can be used with any datatype option.
        /// </summary>
        /// <param name="multiSelect"></param>
        /// <returns></returns>
        IGridBuilder<T> MultiSelect(bool multiSelect);

        /// <summary>
        /// Determines the width of the multiselect column if multiselect is set to true.
        /// </summary>
        /// <param name="multiSelectWidth"></param>
        /// <returns></returns>
        IGridBuilder<T> MultiSelectWidth(int multiSelectWidth);

        /// <summary>
        /// Initializes navigation options
        /// </summary>
        /// <param name="navigator"></param>
        /// <returns></returns>
        IGridBuilder<T> Navigators(Action<IGridNavigator> navigator);

        /// <summary>
        /// Set the initial number of page when we make the request.This parameter is passed to the url for use by the server routine retrieving the data
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        IGridBuilder<T> Page(string page);

        /// <summary>
        /// Defines that we want to use a pager bar to navigate through the records. This must be a valid html element; in our example we gave the div the id of “pager”, but any name is acceptable. Note that the Navigation layer (the “pager” div) can be positioned anywhere you want, determined by your html; in our example we specified that the pager will appear after the Table Body layer. The valid calls can be (using our example) 'pager', '#pager', jQuery('#pager'). I recommend to use the second one.
        /// </summary>
        /// <param name="pager"></param>
        /// <returns></returns>
        IGridBuilder<T> Pager(string pager);

        /// <summary>
        /// Determines the position of the pager in the grid. By default the pager element when created is divided in 3 parts (one part for pager, one part for navigator buttons and one part for record information)
        /// </summary>
        /// <param name="pagerPosition"></param>
        /// <returns></returns>
        IGridBuilder<T> PagerPosition(string pagerPosition);

        /// <summary>
        /// Determines if the Pager buttons should be shown if pager is available. Also valid only if pager is set correctly. The buttons are placed in the pager bar.
        /// </summary>
        /// <param name="pgButtons"></param>
        /// <returns></returns>
        IGridBuilder<T> PgButtons(bool pgButtons);

        /// <summary>
        /// Determines if the input box, where the user can change the number of requested page, should be available. The input box appear in the pager bar.
        /// </summary>
        /// <param name="pgInput"></param>
        /// <returns></returns>
        IGridBuilder<T> PgInput(bool pgInput);

        /// <summary>
        /// Show information about current page status. The first value is the current loaded page. The second value is the total number of pages
        /// </summary>
        /// <param name="pgText"></param>
        /// <returns></returns>
        IGridBuilder<T> PgText(string pgText);

        /// <summary>
        /// Default values prmNames: 
        /// {page:“page”,rows:“rows”, sort: “sidx”, order: “sord”, search:“_search”, nd:“nd”, id:“id”, oper:“oper”, editoper:“edit”, addoper:“add”, deloper:“del”, subgridid:“id”, npage: null, totalrows:“totalrows”} 
        /// Customizes names of the fields sent to the server on a Post. For example, with this setting, you can change the sort order element from “sidx” to “mysort”: prmNames: {sort: “mysort”}. The string that will be posted to the server will then be myurl.php?page=1&rows=10&mysort=myindex&sord=asc rather than myurl.php?page=1&rows=10&sidx=myindex&sord=asc 
        /// When some parameter is set to null they will be not sended to the server. By example if we set prmNames: { nd:null} the nd parameter will not be sended. For npage option see scroll option. 
        /// The options meaning the following 
        /// page - the the requested page - default value page, 
        /// rows - the number of rows requested - default value rows, 
        /// sort - the sorting column - default value sidx, 
        /// order - the sort order default value sord, 
        /// search - the search indicator - default value _search, 
        /// nd - the time passed to the request (for IE browsers not to cache the request) - default value nd, 
        /// id - the name of the id when post data in editing modules - default value id, 
        /// oper - the operation parameter - default value oper, 
        /// editoper - the name of operation when the data is posted in edit mode - default value edit, 
        /// addoper - the name of operation when the data is posted in add mode - default value add,
        /// deloper - the name of operation when the data is posted in delete mode - default value del 
        /// totalrows - the name of the total rows to be obtained from server - see rowTotal - default value totalrows 
        /// subgridid - the name passed when we click to load data in subgrid - default value id
        /// </summary>
        /// <param name="prmNames"></param>
        /// <returns></returns>
        IGridBuilder<T> PrmNames(string prmNames);

        /// <summary>
        /// This array is passed directly to the url. This is associative array and can be used this way: {name1:value1…}. See API methods for manipulation.
        /// </summary>
        /// <param name="postData"></param>
        /// <returns></returns>
        IGridBuilder<T> PostData(string postData);

        /// <summary>
        /// Readonly property. Determines the exactly number of rows in the grid. Do not mix this with records parameter. Instead that in most cases they are equal there is a case where this is not true. By example you define rowNum parameter 15, but you return from server records parameter = 20, then the records parameter will be 20, the reccount parameter will be 15, and in the grid you will have 15 records.
        /// </summary>
        /// <param name="reccount"></param>
        /// <returns></returns>
        IGridBuilder<T> Reccount(int reccount);

        /// <summary>
        /// Determines the position of the record information in the pager. Can be left, center, right
        /// </summary>
        /// <param name="recordPosition"></param>
        /// <returns></returns>
        IGridBuilder<T> RecordPosition(string recordPosition);

        /// <summary>
        /// Readonly property. Determines the number of returned records in grid from the request
        /// </summary>
        /// <param name="records"></param>
        /// <returns></returns>
        IGridBuilder<T> Records(int records);

        /// <summary>
        /// Represent information that can be shown in the pager. Also this option is valid if viewrecords option is set to true. This text appear only if the tottal number of recreds is greater then zero.In order to show or hide some information the items in {} mean the following: {0} the start position of the records depending on page number and number of requested records; {1} - the end position {2} - total records returned from the data
        /// </summary>
        /// <param name="recordText"></param>
        /// <returns></returns>
        IGridBuilder<T> RecordText(string recordText);

        /// <summary>
        /// Assigns a class to columns that are resizable so that we can show a resize handle only for ones that are resizable
        /// </summary>
        /// <param name="resizeClass"></param>
        /// <returns></returns>
        IGridBuilder<T> ResizeClass(string resizeClass);

        /// <summary>
        /// An array to construct a select box element in the pager in which we can change the number of the visible rows. When changed during the execution, this parameter replaces the rowNum parameter that is passed to the url. If the array is empty the element does not appear in the pager. Typical you can set this like [10,20,30]. If the rowNum parameter is set to 30 then the selected value in the select box is 30.
        /// </summary>
        /// <param name="rowList"></param>
        /// <returns></returns>
        IGridBuilder<T> RowList(int[] rowList);

        /// <summary>
        /// If this option is set to true, a new column at left of the grid is added. The purpose of this column is to count the number of available rows, beginning from 1. In this case colModel is extended automatically with new element with name - 'rn'. Also, be careful not to use the name 'rn' in colModel
        /// </summary>
        /// <param name="rowNumbers"></param>
        /// <returns></returns>
        IGridBuilder<T> RowNumbers(bool rowNumbers);

        /// <summary>
        /// Sets how many records we want to view in the grid. This parameter is passed to the url for use by the server routine retrieving the data. Note that if you set this parameter to 10 (i.e. retrieve 10 records) and your server return 15 then only 10 records will be loaded. 
        /// </summary>
        /// <param name="rowNum"></param>
        /// <returns></returns>
        IGridBuilder<T> RowNum(int rowNum);

        /// <summary>
        /// When set this parameter can instruct the server to load the total number of rows needed to work on. Note that rowNum determines the total records displayed in the grid, while rowTotal the total rows on which we operate. When this parameter is set we send a additional parameter to server named totalrows. You can check for this parameter and if it is available you can replace the rows parameter with this one. Mostly this parameter can be combined wit loadonce parameter set to true.
        /// </summary>
        /// <param name="rowTotal"></param>
        /// <returns></returns>
        IGridBuilder<T> RowTotal(int rowTotal);

        /// <summary>
        /// Determines the width of the row number column if rownumbers option is set to true.
        /// </summary>
        /// <param name="rowNumWidth"></param>
        /// <returns></returns>
        IGridBuilder<T> RowNumWidth(int rowNumWidth);

        /// <summary>
        /// This is read only property and is used in Inline and cell editing modules to store the data, before editing the row or cell. See Cell editing and Inline editing.
        /// </summary>
        /// <param name="savedRow"></param>
        /// <returns></returns>
        IGridBuilder<T> SavedRow(string savedRow);

        /// <summary>
        /// Creates dynamic scrolling grids. When enabled, the pager elements are disabled and we can use the vertical scrollbar to load data. When set to true the grid will always hold all the items from the start through to the latest point ever visited. 
        /// When scroll is set to value (eg 1), the grid will just hold the visible lines. This allow us to load the data at portions whitout to care about the memory leaks. Additionally this we have optional extension to the server protocol: npage (see prmNames array). If you set the npage option in prmNames, then the grid will sometimes request more than one page at a time, if not it will just perform multiple gets.
        /// </summary>
        /// <param name="scroll"></param>
        /// <returns></returns>
        IGridBuilder<T> Scroll(bool scroll);

        /// <summary>
        /// Determines the width of the vertical scrollbar. Since different browsers interpret this width differently (and it is difficult to calculate it in all browsers) this can be changed.
        /// </summary>
        /// <param name="scrollOffset"></param>
        /// <returns></returns>
        IGridBuilder<T> ScrollOffset(int scrollOffset);

        /// <summary>
        /// This control the timeout handler when scroll is set to 1.
        /// </summary>
        /// <param name="scrollTimeout"></param>
        /// <returns></returns>
        IGridBuilder<T> ScrollTimeout(int scrollTimeout);

        /// <summary>
        /// When enabled, selecting a row with setSelection scrolls the grid so that the selected row is visible. This is especially useful when we have a verticall scrolling grid and we use form editing with navigation buttons (next or previous row). On navigating to a hidden row, the grid scrolls so the selected row becomes visible.
        /// </summary>
        /// <param name="scrollRows"></param>
        /// <returns></returns>
        IGridBuilder<T> ScrollRows(bool scrollRows);
        
        /// <summary>
        /// Add single/multiple searching feature to the grid
        /// </summary>
        /// <param name="searchGridAction"></param>
        /// <returns></returns>
        IGridBuilder<T> SearchGrid(Action<ISearchGrid> searchGridAction);

        /// <summary>
        /// This options is read only. Determines the currently selected rows when multiselect is set to true. This is one dimensional array and the values in the array correspond to the selected id's in the grid.
        /// </summary>
        /// <param name="selArrrow"></param>
        /// <returns></returns>
        IGridBuilder<T> SelArrrow(string selArrrow);

        /// <summary>
        /// This option is read only. Contain the id of the last selected row. If you sort or apply a pagging this options is set to null
        /// </summary>
        /// <param name="selRow"></param>
        /// <returns></returns>
        IGridBuilder<T> SelRow(string selRow);

        /// <summary>
        /// This option describes the type of calculation of the initial width of each column against with the width of the grid. If the value is true and the value in width option is set then: Every column width is scaled according to the defined option width. Example: if we define two columns with a width of 80 and 120 pixels, but want the grid to have a 300 pixels - then the columns are recalculated as follow: 1- column = 300(new width)/200(sum of all width)*80(column width) = 120 and 2 column = 300/200*120 = 180. The grid width is 300px. If the value is false and the value in width option is set then: The width of the grid is the width set in option. The column width are not recalculated and have the values defined in colModel. If integer is set, the width is calculated according to it.
        /// </summary>
        /// <param name="shrinkToFit"></param>
        /// <returns></returns>
        IGridBuilder<T> ShrinkToFit(bool shrinkToFit);

        /// <summary>
        /// When enabled this option allow column reordering with mouse. Since this option uses jQuery UI sortable widget, be a sure that this widget and the related to widget files are loaded in head tag. Also be a sure too that you mark the grid.jqueryui.js when you download the jqGrid.
        /// </summary>
        /// <param name="sortable"></param>
        /// <returns></returns>
        IGridBuilder<T> Sortable(bool sortable);

        /// <summary>
        /// The initial sorting name when we use datatypes xml or json (data returned from server). This parameter is added to the url. If set and the index (name) match the name from colModel then to this column by default is added a image sorting icon, according to the parameter sortorder (below). See prmNames.
        /// </summary>
        /// <param name="sortName"></param>
        /// <returns></returns>
        IGridBuilder<T> SortName(string sortName);

        /// <summary>
        /// The initial sorting order when we use datatypes xml or json (data returned from server).This parameter is added to the url - see prnNames. Two possible values - asc or desc.
        /// </summary>
        /// <param name="sortOrder"></param>
        /// <returns></returns>
        IGridBuilder<T> SortOrder(string sortOrder);

        /// <summary>
        /// If set to true this enables using a subgrid. If the subGrid is enabled a additional column at left side is added to the basic grid. This column contains a 'plus' image which indicate that the user can click on it to expand the row. By default all rows are collapsed.
        /// </summary>
        /// <param name="subGrid"></param>
        /// <returns></returns>
        IGridBuilder<T> SubGrid(bool subGrid);

        /// <summary>
        /// A set of additional options for the subgrid. For more information and default values
        /// </summary>
        /// <param name="subGridOptions"></param>
        /// <returns></returns>
        IGridBuilder<T> SubGridOptions(string subGridOptions);

        /// <summary>
        /// This property, which describes the model of the subgrid, has an effect only if the subGrid property is set to true. It is an array in which we describe the column model for the subgrid data.
        /// </summary>
        /// <param name="subGridModel"></param>
        /// <returns></returns>
        IGridBuilder<T> SubGridModel(string subGridModel);

        /// <summary>
        /// This option allow loading subgrid as a service. If not set, the datatype parameter of the parent grid is used.
        /// </summary>
        /// <param name="subGridType"></param>
        /// <returns></returns>
        IGridBuilder<T> SubGridType(string subGridType);

        /// <summary>
        /// This option has effect only if subGrid option is set to true. This option points to the file from which we get the data for the subgrid. jqGrid adds the id of the row to this url as parameter. If there is a need to pass additional parameters, use the params option in subGridModel. 
        /// </summary>
        /// <param name="subGridUrl"></param>
        /// <returns></returns>
        IGridBuilder<T> SubGridUrl(string subGridUrl);

        /// <summary>
        /// Determines the width of the subGrid column if subgrid is enabled.
        /// </summary>
        /// <param name="subGridWidth"></param>
        /// <returns></returns>
        IGridBuilder<T> SubGridWidth(int subGridWidth);

        /// <summary>
        /// This option defines the toolbar of the grid. This is array with two values in which the first value enables the toolbar and the second defines the position relative to body Layer. Possible values “top”,”bottom”, “both”. When we set toolbar: [true,”both”] two toolbars are created – one on the top of table data and one of the bottom of the table data. When we have two toolbars then we create two elements (div). The id of the top bar is constructed like “t_”+id of the grid and the bottom toolbar the id is “tb_”+id of the grid. In case when only one toolbar is created we have the id as “t_” + id of the grid, independent of where this toolbar is created (top or bottom)
        /// </summary>
        /// <param name="toolbar"></param>
        /// <returns></returns>
        IGridBuilder<T> Toolbar(string toolbar);

        /// <summary>
        /// When enabled this option place a pager element at top of the grid below the caption (if available). If another pager is defined both can coexists and are refreshed in sync. The id of the new created pager is a combination of the gridid+“_toppager”.
        /// </summary>
        /// <param name="topPager"></param>
        /// <returns></returns>
        IGridBuilder<T> TopPager(bool topPager);

        /// <summary>
        /// Readonly parameter. Measure the loading time of the records - currently available only when we load xml or json data. Also the check begin when the request is complete and we begin to insert data into the grid and ends when the last row is added.
        /// </summary>
        /// <param name="totalTime"></param>
        /// <returns></returns>
        IGridBuilder<T> TotalTime(int totalTime);

        /// <summary>
        /// Determines the initial datatype (see datatype option). Usually this should not be changed. During the reading process this option is equal to the datatype option.
        /// </summary>
        /// <param name="treeDataType"></param>
        /// <returns></returns>
        IGridBuilder<T> TreeDataType(string treeDataType);

        /// <summary>
        /// Enables (disables) the tree grid format. 
        /// </summary>
        /// <param name="treeGrid"></param>
        /// <returns></returns>
        IGridBuilder<T> TreeGrid(bool treeGrid);

        /// <summary>
        /// Deteremines the method used for the treeGrid. Can be nested or adjacency.
        /// </summary>
        /// <param name="treeGridModel"></param>
        /// <returns></returns>
        IGridBuilder<T> TreeGridModel(string treeGridModel);

        /// <summary>
        /// This array set the icons used in the tree. The icons should be a valid names from UI theme roller images. The default values are: {plus:'ui-icon-triangle-1-e',minus:'ui-icon-triangle-1-s',leaf:'ui-icon-radio-off'}
        /// </summary>
        /// <param name="treeIcons"></param>
        /// <returns></returns>
        IGridBuilder<T> TreeIcons(string treeIcons);

        /// <summary>
        /// extends the colModel defined in the basic grid. The fields described here are added to end of the colModel array and are hidden. This means that the data returned from the server should have values for these fields. 
        /// </summary>
        /// <param name="treeReader"></param>
        /// <returns></returns>
        IGridBuilder<T> TreeReader(string treeReader);

        /// <summary>
        /// Determines the level where the root element begins when treeGrid is enabled
        /// </summary>
        /// <param name="treeRootLevel"></param>
        /// <returns></returns>
        IGridBuilder<T> TreeRootLevel(int treeRootLevel);

        /// <summary>
        /// The url of the file that holds the request
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        IGridBuilder<T> Url(string url);

        /// <summary>
        /// This array contain custom information from the request. Can be used at any time.
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        IGridBuilder<T> UserData(string userData);

        /// <summary>
        /// When set to true we directly place the user data array userData at footer. The rules are as follow: If the userData array contain name which is equal to those of colModel then the value is placed in that column.If there are no such values nothing is palced. Note that if this option is used we use the current formatter options (if available) for that column
        /// </summary>
        /// <param name="userDataOnFooter"></param>
        /// <returns></returns>
        IGridBuilder<T> UserDataOnFooter(bool userDataOnFooter);

        /// <summary>
        /// If true, jqGrid displays the beginning and ending record number in the grid, out of the total number of records in the query. This information is shown in the pager bar (bottom right by default)in this format: “View X to Y out of Z”. If this value is true, there are other parameters that can be adjusted, including 'emptyrecords' and 'recordtext'.
        /// </summary>
        /// <param name="viewRecords"></param>
        /// <returns></returns>
        IGridBuilder<T> ViewRecords(bool viewRecords);

        /// <summary>
        /// The purpose of this parameter is to define different look and behavior of sorting icons that appear near the header. This parameter is array with the following default options viewsortcols : [false,'vertical',true]. The first parameter determines if all icons should be viewed at the same time when all columns have sort property set to true. The default of false determines that only the icons of the current sorting column should be viewed. Setting this parameter to true causes all icons in all sortable columns to be viewed.
        /// The second parameter determines how icons should be placed - vertical means that the sorting icons are one under another. 'horizontal' means that the icons should be one near other. 
        /// The third parameter determines the click functionality. If set to true the columns are sorted if the header is clicked. If set to false the columns are sorted only when the icons are clicked. 
        /// Important note: When set a third parameter to false be a sure that the first parameter is set to true, otherwise you will loose the sorting.
        /// </summary>
        /// <param name="viewSortCols"></param>
        /// <returns></returns>
        IGridBuilder<T> ViewSortCols(string viewSortCols);

        /// <summary>
        /// If this option is not set, the width of the grid is a sum of the widths of the columns defined in the colModel (in pixels). If this option is set, the initial width of each column is set according to the value of shrinkToFit option.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        IGridBuilder<T> Width(string width);

        /// <summary>
        /// Array which describes the structure of the expected xml data.
        /// </summary>
        /// <param name="xmlReader"></param>
        /// <returns></returns>
        IGridBuilder<T> XmlReader(string xmlReader);

        /// <summary>
        /// Name of the grid
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IGridBuilder<T> Name(string name);

        /// <summary>
        /// Render the JqGrid sources
        /// </summary>
        /// <param name="renderGridHtml"></param>
        /// <returns></returns>
        MvcHtmlString Render(bool renderGridHtml = false);
    }
}
