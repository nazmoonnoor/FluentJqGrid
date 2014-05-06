namespace FluentJqGrid.Infrastructure
{
    public interface IGridEvents
    {
        /// <summary>
        /// This event fires after every inserted row.
        /// rowid is the id of the inserted row 
        /// rowdata is an array of the data to be inserted into the row. This is array of type name: value, where the name is a name from colModel 
        /// rowelem is the element from the response. If the data is xml this is the xml element of the row; if the data is json this is array containing all the data for the row 
        /// Note: this event does not fire if gridview option is set to true
        /// Parameters: rowid, rowdata, rowelem
        /// </summary>
        /// <param name="afterInsertRows"></param>
        /// <returns></returns>
        IGridEvents AfterInsertRow(string afterInsertRows);

        /// <summary>
        /// This event fire before proccesing the data from the server. Note that the data is formatted depended on the value of the datatype parameter - i.e if the datatype is 'json' for example the data is JavaScript object
        /// Parameters: data, status, xhr
        /// </summary>
        /// <param name="beforeProcessing"></param>
        /// <returns></returns>
        IGridEvents BeforeProcessing(string beforeProcessing);

        /// <summary>
        /// This event fire before requesting any data. Also does not fire if datatype is function. If the event return false the request is not made to the server
        /// Parameters: none
        /// </summary>
        /// <param name="beforeRequest"></param>
        /// <returns></returns>
        IGridEvents BeforeRequest(string beforeRequest);

        /// <summary>
        /// This event fire when the user click on the row, but before select them. 
        /// rowid is the id of the row. 
        /// e is the event object 
        /// This event should return boolean true or false. If the event return true the selection is done. If the event return false the row is not selected and any other action if defined does not occur.
        /// Parameters: rowid, e
        /// </summary>
        /// <param name="beforeSelectRow"></param>
        /// <returns></returns>
        IGridEvents BeforeSelectRow(string beforeSelectRow);

        /// <summary>
        /// This fires after all the data is loaded into the grid and all other processes are complete. Also the event fires independent from the datatype parameter and after sorting paging and etc.
        /// Parameters: none
        /// </summary>
        /// <param name="gridComplete"></param>
        /// <returns></returns>
        IGridEvents GridComplete(string gridComplete);

        /// <summary>
        /// A pre-callback to modify the XMLHttpRequest object (xhr) before it is sent. Use this to set custom headers etc. Returning false will cancel the request.
        /// Parameters: nonexhr, settings
        /// </summary>
        /// <param name="loadBeforeSend"></param>
        /// <returns></returns>
        IGridEvents LoadBeforeSend(string loadBeforeSend);

        /// <summary>
        /// This event is executed immediately after every server request. data Data from the response depending on datatype grid parameter.
        /// Parameters: data
        /// </summary>
        /// <param name="loadComplete"></param>
        /// <returns></returns>
        IGridEvents LoadComplete(string loadComplete);

        /// <summary>
        /// A function to be called if the request fails. The function gets passed three arguments: The XMLHttpRequest object (xhr), a string describing the type of error (status) that occurred and an optional exception object (error), if one occurred.
        /// Parameters: xhr, status, error
        /// </summary>
        /// <param name="loadError"></param>
        /// <returns></returns>
        IGridEvents LoadError(string loadError);

        /// <summary>
        /// Fires when we click on particular cell in the grid.
        /// rowid is the id of the row 
        /// iCol is the index of the cell,
        /// cellcontent is the content of the cell,
        /// e is the event object element where we click.
        /// (Note that this available when we not use cell editing module and is disabled when using cell editing).
        /// Parameters: rowid, iCol, cellcontent, e
        /// </summary>
        /// <param name="onCellSelect"></param>
        /// <returns></returns>
        IGridEvents OnCellSelect(string onCellSelect);

        /// <summary>
        /// Raised immediately after row was double clicked. 
        /// rowid is the id of the row, 
        /// iRow is the index of the row (do not mix this with the rowid),
        /// iCol is the index of the cell. 
        /// e is the event object
        /// Parameters: rowid, iRow, iCol, e
        /// </summary>
        /// <param name="onDblClickRow"></param>
        /// <returns></returns>
        IGridEvents OnDblClickRow(string onDblClickRow);

        /// <summary>
        /// Fire after clicking to hide or show grid (hidegrid:true); gridstate is the state of the grid - can have two values - visible or hidden
        /// Parameters: gridstate
        /// </summary>
        /// <param name="onHeaderClick"></param>
        /// <returns></returns>
        IGridEvents OnHeaderClick(string onHeaderClick);

        /// <summary>
        /// This event fires after click on [page button] and before populating the data. Also works when the user enters a new page number in the page input box (and presses [Enter]) and when the number of requested records is changed via the select box. To this event we pass only one parameter pgButton See pager. If this event return 'stop' the processing is stopped and you can define your own custom paging
        /// Parameters: pgButton
        /// </summary>
        /// <param name="onPaging"></param>
        /// <returns></returns>
        IGridEvents OnPaging(string onPaging);

        /// <summary>
        /// Raised immediately after row was right clicked. 
        /// rowid is the id of the row, 
        /// iRow is the index of the row (do not mix this with the rowid),
        /// iCol is the index of the cell.
        /// e is the event object. 
        /// Note - this event does not work in Opera browsers, since Opera does not support oncontextmenu event
        /// Parameters: rowid, iRow, iCol, e
        /// </summary>
        /// <param name="onRightClickRow"></param>
        /// <returns></returns>
        IGridEvents OnRightClickRow(string onRightClickRow);

        /// <summary>
        /// This event fires when multiselect option is true and you click on the header checkbox. 
        /// aRowids array of the selected rows (rowid's). 
        /// status - boolean variable determining the status of the header check box - true if checked, false if not checked. 
        /// Note that the aRowids alway contain the ids when header checkbox is checked or unchecked.
        /// Parameters: aRowids, status
        /// </summary>
        /// <param name="onSelectAll"></param>
        /// <returns></returns>
        IGridEvents OnSelectAll(string onSelectAll);

        /// <summary>
        /// Raised immediately after row was clicked. 
        /// rowid is the id of the row,
        /// status is the status of the selection. Can be used when multiselect is set to true. true if the row is selected, false if the row is deselected.
        /// Parameters: rowid, status
        /// </summary>
        /// <param name="onSelectRow"></param>
        /// <returns></returns>
        IGridEvents OnSelectRow(string onSelectRow);

        /// <summary>
        /// Raised immediately after sortable column was clicked and before sorting the data. 
        /// index is the index name from colModel, 
        /// iCol is the index of column, 
        /// sortorder is the new sorting order - can be 'asc' or 'desc'. 
        /// If this event return 'stop' the sort processing is stopped and you can define your own custom sorting
        /// Parameters: index, iCol, sortorder
        /// </summary>
        /// <param name="onSortCol"></param>
        /// <returns></returns>
        IGridEvents OnSortCol(string onSortCol);

        /// <summary>
        /// Event which is called when we start resize a column. event is the event object, index is the index of the column in colModel.
        /// Parameters: event, index
        /// </summary>
        /// <param name="resizeStart"></param>
        /// <returns></returns>
        IGridEvents ResizeStart(string resizeStart);

        /// <summary>
        /// Event which is called after the column is resized. newwidth is the is the new width of the column , index is the index of the column in colModel.
        /// Parameters: newwidth, index
        /// </summary>
        /// <param name="resizeStop"></param>
        /// <returns></returns>
        IGridEvents ResizeStop(string resizeStop);

        /// <summary>
        /// If set this event can serialize the data passed to the ajax request. The function should return the serialized data. This event can be used when a custom data should be passed to the server - e.g - JSON string, XML string and etc. To this event we pass the postData array.
        /// Parameters: postData
        /// </summary>
        /// <param name="serializeGridData"></param>
        /// <returns></returns>
        IGridEvents SerializeGridData(string serializeGridData);
    }
}