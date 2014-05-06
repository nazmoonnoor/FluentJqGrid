namespace FluentJqGrid.Infrastructure.Search
{
    public interface ISearchGrid
    {
        /// <summary>
        /// This event fires (if defined) every time after the search dialog is shown
        /// </summary>
        /// <param name="afterShowSearch"></param>
        /// <returns></returns>
        ISearchGrid AfterShowSearch(string afterShowSearch);

        /// <summary>
        /// This event fires (if defined) every time before the search dialog is shown
        /// </summary>
        /// <param name="beforeShowSearch"></param>
        /// <returns></returns>
        ISearchGrid BeforeShowSearch(string beforeShowSearch);

        /// <summary>
        /// If set to true this closes the search dialog after the user apply a search - i.e. click on Find button
        /// </summary>
        /// <param name="closeAfterSearch"></param>
        /// <returns></returns>
        ISearchGrid CloseAfterSearch(bool? closeAfterSearch);

        /// <summary>
        /// If set to true this closes the search dialog after the user apply a reset - i.e. click on Reset button
        /// </summary>
        /// <param name="closeAfterReset"></param>
        /// <returns></returns>
        ISearchGrid CloseAfterReset(bool? closeAfterReset);

        /// <summary>
        /// Enables or disables draging of the modal
        /// </summary>
        /// <param name="drag"></param>
        /// <returns></returns>
        ISearchGrid Drag(bool? drag);

        /// <summary>
        /// Enables or disables resizing of the modal
        /// </summary>
        /// <param name="resize"></param>
        /// <returns></returns>
        ISearchGrid Resize(bool? resize);

        /// <summary>
        /// Is set to true the search dialog becomes modal
        /// </summary>
        /// <param name="modal"></param>
        /// <returns></returns>
        ISearchGrid Modal(bool? modal);

        /// <summary>
        /// Defines the width os the search dialog
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        ISearchGrid Width(int? width);

        /// <summary>
        /// Defines the height of the search dialog
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        ISearchGrid Height(string height);

        /// <summary>
        /// The caption of the modal
        /// </summary>
        /// <param name="caption"></param>
        /// <returns></returns>
        ISearchGrid Caption(string caption);

        /// <summary>
        /// If set to true shows the query which is generated when the user defines the conditions for the search. Valid only in advanced search. Again with this a button near search button appear which allows the user to show or hide the query string interactively
        /// </summary>
        /// <param name="showQuery"></param>
        /// <returns></returns>
        ISearchGrid ShowQuery(bool? showQuery);

        /// <summary>
        /// The text in the find button
        /// </summary>
        /// <param name="find"></param>
        /// <returns></returns>
        ISearchGrid Find(string find);

        /// <summary>
        /// If set to true this activates the advanced searching
        /// </summary>
        /// <param name="multipleSearch"></param>
        /// <returns></returns>
        ISearchGrid MultipleSearch(bool? multipleSearch);

        /// <summary>
        /// If set to true this activates the advanced searching with a possibilities to define a complex condfitions
        /// </summary>
        /// <param name="multipleGroup"></param>
        /// <returns></returns>
        ISearchGrid MultipleGroup(bool? multipleGroup);

        /// <summary>
        /// Translation strings that corresponds to the sopt options
        /// </summary>
        /// <param name="oData"></param>
        /// <returns></returns>
        ISearchGrid OData(string oData);

        /// <summary>
        /// If defined this event fires when the dialog is closed. Can return true or false. If the event return false the dialog will not be closed
        /// </summary>
        /// <param name="onClose"></param>
        /// <returns></returns>
        ISearchGrid OnClose(string onClose);

        /// <summary>
        /// This function if defined is lunched every time the filter is redrawed - the filter is redrawed evey time when we add or delet rules or fields Tio this function we pass the search parameters as parameter
        /// </summary>
        /// <param name="afterRedraw"></param>
        /// <returns></returns>
        ISearchGrid AfterRedraw(string afterRedraw);

        /// <summary>
        /// If defined this event fires when the search Button is clicked.
        /// </summary>
        /// <param name="onSearch"></param>
        /// <returns></returns>
        ISearchGrid OnSearch(string onSearch);

        /// <summary>
        /// If defined this function fire if reset button is activated
        /// </summary>
        /// <param name="onReset"></param>
        /// <returns></returns>
        ISearchGrid OnReset(string onReset);

        /// <summary>
        /// Is this option is set to true the search dialogue is closed if the user press ESC key
        /// </summary>
        /// <param name="closeOnEscape"></param>
        /// <returns></returns>
        ISearchGrid CloseOnEscape(bool? closeOnEscape);

        /// <summary>
        /// This event occurs only once when the modal is created
        /// </summary>
        /// <param name="onInitializeSearch"></param>
        /// <returns></returns>
        ISearchGrid OnInitializeSearch(string onInitializeSearch);

        /// <summary>
        /// This option is valid only in navigator options. If set to true the dialog appear automatically when the grid is constructed for first time
        /// </summary>
        /// <param name="showOnLoad"></param>
        /// <returns></returns>
        ISearchGrid ShowOnLoad(bool? showOnLoad);

        /// <summary>
        /// if searchrules are defined this turn on of error checking. If there is a error in the input the filter is not posted to the server and a error message appear.
        /// </summary>
        /// <param name="errorcheck"></param>
        /// <returns></returns>
        ISearchGrid Errorcheck(bool? errorcheck);

        /// <summary>
        /// The text for the clear (reset) button
        /// </summary>
        /// <param name="reset"></param>
        /// <returns></returns>
        ISearchGrid Reset(string reset);

        /// <summary>
        /// See sopt description
        /// </summary>
        /// <param name="sField"></param>
        /// <returns></returns>
        ISearchGrid SField(string sField);

        /// <summary>
        /// Aplicable to advanced searching. 
        /// </summary>
        /// <param name="sFilter"></param>
        /// <returns></returns>
        ISearchGrid SFilter(string sFilter);

        /// <summary>
        /// See sopt description
        /// </summary>
        /// <param name="soper"></param>
        /// <returns></returns>
        ISearchGrid SOper(string soper);

        /// <summary>
        /// Use this option to set common search rules. If not set all the available options will be used. All available option are: ['eq','ne','lt','le','gt','ge','bw','bn','in','ni','ew','en','cn','nc','nu','nn'] The corresponding texts are in language file and mean the following: ['equal','not equal', 'less', 'less or equal','greater','greater or equal', 'begins with','does not begin with','is in','is not in','ends with','does not end with','contains','does not contain','is null','is not null'] Note that the elements in sopt array can be mixed in any order.
        /// </summary>
        /// <param name="sopt"></param>
        /// <returns></returns>
        ISearchGrid Sopt(string sopt);

        /// <summary>
        /// See sopt description
        /// </summary>
        /// <param name="sValue"></param>
        /// <returns></returns>
        ISearchGrid SValue(string sValue);

        /// <summary>
        /// If this option is set to 0 the overlay in grid is disabled and the user can interact with the grid while search dialog is active
        /// </summary>
        /// <param name="overlay"></param>
        /// <returns></returns>
        ISearchGrid Overlay(int? overlay);

        /// <summary>
        /// If defined this should be a valid id in the DOM. Also if this option is set the filter is inserted as child of this element
        /// </summary>
        /// <param name="layer"></param>
        /// <returns></returns>
        ISearchGrid Layer(string layer);

        /// <summary>
        /// Defines the name of the templates used for easy user input - by example like this : ['Template1', 'Template2',…]. See grid demo how to define templates.
        /// </summary>
        /// <param name="tmplNames"></param>
        /// <returns></returns>
        ISearchGrid TmplNames(string tmplNames);

        /// <summary>
        /// if defined this should correspond to the tmplNames. See demo how to define template
        /// </summary>
        /// <param name="tmplFilters"></param>
        /// <returns></returns>
        ISearchGrid TmplFilters(string tmplFilters);

        /// <summary>
        /// If a template is defined a select element appear between the Reset and Find buttons. This is a the text describing the select
        /// </summary>
        /// <param name="tmplLabel"></param>
        /// <returns></returns>
        ISearchGrid TmplLabel(string tmplLabel);
    }
}