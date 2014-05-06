using System.Collections.Generic;

namespace FluentJqGrid.Infrastructure.Edit
{
    public interface IEditSelect
    {
        /// <summary>
        /// When edittype is 'select', jqGrid constructs Select tag
        /// This method set the editoptions value as object
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        IEditSelect Value(Dictionary<string, string> value);

        /// <summary>
        /// This option is valid only for elements of type select - i.e., edittype:select and should be the URL to get the AJAX data for the select element. The data is obtained via an AJAX call and should be a valid HTML select element with the desired options <select><option value='1'>One</option>…</select>. You can use option group. 
        /// The AJAX request is called only once when the element is created. 
        /// In the inline edit or the cell edit module it is called every time when you edit a new row or cell. In the form edit module only once.
        /// </summary>
        /// <param name="dataUrl"></param>
        /// <returns></returns>
        IEditSelect DataUrl(string dataUrl);

        /// <summary>
        /// This option is relevant only if the dataUrl parameter is set. When the server response can not build the select element, you can use your own function to build the select. The function should return a string containing the select and options value(s) as described in dataUrl option. Parameter passed to this function is the server response
        /// </summary>
        /// <param name="buildSelect"></param>
        /// <returns></returns>
        IEditSelect BuildSelect(string buildSelect);

        /// <summary>
        /// We pass the element object to this function, if defined. This function is called only once when the element is created. Example : 
        /// …editoptions: { dataInit : function (elem) { 
        /// $(elem).autocomplete(); 
        /// } 
        /// } 
        /// The event is called only once when the element is created. 
        /// In the inline edit or the cell edit module it is called every time when you edit a new row or cell. In the form edit module only once if the recreateForm option is set to false, or every time if the same option is set to true . 
        /// Note: Some plugins require the position of the element in the DOM and since this event is raised before inserting the element into the DOM you can use a setTimeout function to accomplish the desired action. This is especially valid for jQuery UI datepicker (1.7.x and up releases)
        /// </summary>
        /// <param name="dataInit"></param>
        /// <returns></returns>
        IEditSelect DataInit(string dataInit);

        /// <summary>
        /// list of events to apply to the data element; uses $(”#id”).bind(type, [data], fn) to bind events to data element. Should be described like this: 
        /// … editoptions: { dataEvents: [ 
        ///     { type: 'click', data: { i: 7 }, fn: function(e) { console.log(e.data.i); } }, 
        ///     { type: 'keypress', fn: function(e) { console.log('keypress'); } } 
        ///   ] 
        /// }
        /// </summary>
        /// <param name="dataEvents"></param>
        /// <returns></returns>
        IEditSelect DataEvents(string dataEvents);

        /// <summary>
        /// The option can be string or function. This option is valid only in Form Editing module when used with editGridRow method in add mode. If defined the input element is set with this value if only element is empty. If used in selects the text should be provided and not the key. Also when a function is used the function should return value.
        /// </summary>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        IEditSelect DefaultValue(string defaultValue);

        /// <summary>
        /// If set to true a string 'null' is send to the server when the data in that field is empty
        /// </summary>
        /// <param name="nullIfEmpty"></param>
        /// <returns></returns>
        IEditSelect NullIfEmpty(bool nullIfEmpty);
        
        /// <summary>
        /// All possible attributes for 'select'
        /// </summary>
        /// <param name="attributes"></param>
        IEditSelect Attributs(string attributes);
    }
}