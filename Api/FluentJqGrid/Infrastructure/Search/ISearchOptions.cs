namespace FluentJqGrid.Infrastructure.Search
{
    public interface ISearchOptions
    {
        /// <summary>
        /// This option is valid only for the elements of type select - i.e stype:'select'. 
        /// The option represent the url from where we load the select element. 
        /// When this option is set the element will be filled with values from the ajax request. 
        /// The data should be a valid html select element with the desired options. 
        /// By example the request should contain <select><option value=“1”>One</option> <option value=“2”>Two</option></select>. 
        /// This is called only once.
        /// </summary>
        /// <param name="dataUrl"></param>
        /// <returns></returns>
        ISearchOptions DataUrl(string dataUrl);

        /// <summary>
        /// This option have sense only if the dataUrl parameter is set. 
        /// In case where the server response can not build the select element you can use your on function to build the select. 
        /// The function should return a string containing the select and options value(s) as described in dataUrl option. 
        /// Parameter passed to this function is the server response
        /// </summary>
        /// <param name="buildSelect"></param>
        /// <returns></returns>
        ISearchOptions BuildSelect(string buildSelect);
        
        /// <summary>
        /// If set this function is called only once when the element is created. To this function we pass the element object.
        /// dataInit: function(elem) { 
        ///     do something 
        /// } 
        /// Also use this function to attach datepicker, time picker and etc. Example: 
        /// dataInit : function (elem) {
        ///     $(elem).datepicker();
        /// }
        /// </summary>
        /// <param name="dataInit"></param>
        /// <returns></returns>
        ISearchOptions DataInit(string dataInit);

        /// <summary>
        /// List of events to apply to the data element; uses $(”#id”).bind(type, [data], fn) to bind events to data element. Should be described like this: 
        /// dataEvents: [ 
        ///     { type: 'click', data: { i: 7 }, fn: function(e) { console.log(e.data.i); }},
        ///     { type: 'keypress', fn: function(e) { console.log('keypress'); } } 
        /// ]
        /// </summary>
        /// <param name="dataEvents"></param>
        /// <returns></returns>
        ISearchOptions DataEvents(string dataEvents);

        /// <summary>
        /// attr is object where we can set valid attributes to the created element. By example: 
        /// attr : { title: “Some title” } 
        /// Will set a title of the searched element
        /// </summary>
        /// <param name="attr"></param>
        /// <returns></returns>
        ISearchOptions Attr(string attr);

        /// <summary>
        /// By default hidden elements in the grid are not searchable . In order to enable searching when the field is hidden set this option to true
        /// </summary>
        /// <param name="searchHidden"></param>
        /// <returns></returns>
        ISearchOptions SearchHidden(bool searchHidden);

        /// <summary>
        /// This option is used only in advanced single field searching and determines the operation that is applied to the element. If not set all the available options will be used. All available option are: 
        /// ['eq','ne','lt','le','gt','ge','bw','bn','in','ni','ew','en','cn','nc'] 
        /// The corresponding texts are in language file and mean the following: 
        /// ['equal','not equal', 'less', 'less or equal','greater','greater or equal', 'begins with','does not begin with','is in','is not in','ends with','does not end with','contains','does not contain'] 
        /// Note that the elements in sopt array can be mixed in any order.
        /// </summary>
        /// <param name="sopt"></param>
        /// <returns></returns>
        ISearchOptions Sopt(string sopt);

        /// <summary>
        /// If not empty set a default value in the search input element.
        /// </summary>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        ISearchOptions DefaultValue(string defaultValue);

        /// <summary>
        /// The option is used only for stype select and defines the select options in the search dialogs. When set for stype select and dataUrl option is not set, the value can be a string or object. 
        /// If the option is a string it must contain a set of value:label pairs with the value separated from the label with a colon (:) and ended with(;). The string should not end with a (;)- editoptions:{value:“1:One;2:Two”}.If set as object it should be defined as pair value:name - editoptions:{value:{1:'One',2:'Two'}}
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        ISearchOptions Value(string value);
    }
}