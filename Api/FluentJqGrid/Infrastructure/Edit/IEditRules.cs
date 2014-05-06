namespace FluentJqGrid.Infrastructure.Edit
{
    public interface IEditRules
    {
        /// <summary>
        /// This option is valid only in form editing module. By default the hidden fields are not editable. If the field is hidden in the grid and edithidden is set to true, the field can be edited when add or edit methods are called.
        /// </summary>
        /// <param name="editHidden"></param>
        /// <returns></returns>
        IEditRules EditHidden(bool editHidden);

        /// <summary>
        /// (true or false) if set to true, the value will be checked and if empty, an error message will be displayed.
        /// </summary>
        /// <param name="required"></param>
        /// <returns></returns>
        IEditRules Required(bool required);

        /// <summary>
        /// (true or false) if set to true, the value will be checked and if this is not a number, an error message will be displayed.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        IEditRules Number(bool number);

        /// <summary>
        /// (true or false) if set to true, the value will be checked and if this is not a integer, an error message will be displayed.
        /// </summary>
        /// <param name="integer"></param>
        /// <returns></returns>
        IEditRules Integer(bool integer);

        /// <summary>
        /// if set, the value will be checked and if the value is less than this, an error message will be displayed.
        /// </summary>
        /// <param name="minValue"></param>
        /// <returns></returns>
        IEditRules MinValue(int minValue);

        /// <summary>
        /// if set, the value will be checked and if the value is more than this, an error message will be displayed.
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        IEditRules MaxValue(int maxValue);

        /// <summary>
        /// if set to true, the value will be checked and if this is not valid e-mail, an error message will be displayed
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        IEditRules Email(bool email);

        /// <summary>
        /// if set to true, the value will be checked and if this is not valid url, an error message will be displayed
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        IEditRules Url(bool url);

        /// <summary>
        /// if set to true a value from datefmt option is get (if not set ISO date is used) and the value will be checked and if this is not valid date, an error message will be displayed
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        IEditRules Date(bool date);

        /// <summary>
        /// if set to true, the value will be checked and if this is not valid time, an error message will be displayed. Currently we support only hh:mm format and optional am/pm at the end
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        IEditRules Time(bool time);

        /// <summary>
        /// if set to true allow definition of the custom checking rules via a custom function. See below
        /// </summary>
        /// <param name="custom"></param>
        /// <returns></returns>
        IEditRules Custom(bool custom);

        /// <summary>
        /// this function should be used when a custom option is set to true. Parameters passed to this function are the value, which should be checked and the name - the property from colModel. The function should return array with the following parameters: first parameter - true or false. The value of true mean that the checking is successful false otherwise; the second parameter have sense only if the first value is false and represent the error message which will be displayed to the user. Typically this can look like this [false,”Please enter valid value”]
        /// </summary>
        /// <param name="customFunction"></param>
        /// <returns></returns>
        IEditRules CustomFunction(string customFunction);
    }
}