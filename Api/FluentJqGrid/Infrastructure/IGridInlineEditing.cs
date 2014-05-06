namespace FluentJqGrid.Infrastructure
{
    public interface IGridInlineEditing
    {
        /// <summary>
        /// rowID : "new_row",
        /// initdata : {},
        /// position :"first",
        /// useDefValues : false,
        /// useFormatter : false,
        /// addRowParams : {extraparam:{}}
        /// </summary>
        /// <param name="buttonId">Id of the button</param>
        /// <param name="initdata"></param>
        /// <param name="position"></param>
        /// <param name="useDefValues"></param>
        /// <param name="useFormatter"></param>
        /// <param name="addRowParams"></param>
        void AddRow(string buttonId, string initdata = null, string position = null, bool? useDefValues = null, bool? useFormatter = null, string addRowParams = null);

        /// <summary>
        /// keys: when set to true we can use [Enter] key to save the row and [Esc] to cancel editing.
        /// oneditfunc: fires after successfully accessing the row for editing, prior to allowing user access to the input fields. The row's id is passed as a parameter to this function.
        /// If keys is true, then the remaining settings – succesfunc, url, extraparam, aftersavefunc, errorfunc and afterrestorefunc - are passed as parameters to the saveRow method when the [Enter] key is pressed (saveRow does not need to be defined as jqGrid calls it automatically). For more information see saveRow method below. 
        /// </summary>
        /// <param name="buttonId">Id of the button</param>
        /// <param name="keys"></param>
        /// <param name="oneditfunc"></param>
        /// <param name="succesfunc"></param>
        /// <param name="url"></param>
        /// <param name="extraparam"></param>
        /// <param name="aftersavefunc"></param>
        /// <param name="errorfunc"></param>
        /// <param name="afterrestorefunc"></param>
        void EditRow(string buttonId, string keys = null, string oneditfunc = null,
            string succesfunc = null, string url = null, string extraparam = null, string aftersavefunc = null, string errorfunc = null, string afterrestorefunc = null);

        /// <summary>
        /// succesfunc: if defined, this function is called immediately after the request is successful. This function is passed the data returned from the server. Depending on the data from server; this function should return true or false.
        /// url: if defined, this parameter replaces the editurl parameter from the options array. If set to 'clientArray', the data is not posted to the server but rather is saved only to the grid (presumably for later manual saving).
        /// extraparam: an array of type name: value. When set these values are posted along with the other values to the server.
        /// aftersavefunc: if defined, this function is called after the data is saved to the server. Parameters passed to this function are the rowid and the response from the server request. Also the event is called too when the url is set to 'clientArray'.
        /// errorfunc: if defined, this function is called after the data is saved to the server. Parameters passed to this function are the rowid and the the response from the server request.
        /// afterrestorefunc if defined, this function is called in restoreRow (in case the row is not saved with success) method after restoring the row. To this function we pass the rowid
        /// </summary>
        /// <param name="buttonId">Id of the button</param>
        /// <param name="succesfunc"></param>
        /// <param name="url"></param>
        /// <param name="extraparam"></param>
        /// <param name="aftersavefunc"></param>
        /// <param name="errorfunc"></param>
        /// <param name="afterrestorefunc"></param>
        void SaveRow(string buttonId, string succesfunc = null, string url = null, string extraparam = null, string aftersavefunc = null,
            string errorfunc = null, string afterrestorefunc = null);

        /// <summary>
        /// afterrestorefunc if defined this function is called in after the row is restored. To this function we pas the rowid
        /// </summary>
        /// <param name="buttonId">Id of the button</param>
        /// <param name="afterrestorefunc"></param>
        void RestoreRow(string buttonId, string afterrestorefunc = null);

    }
}