namespace FluentJqGrid.Infrastructure.Search
{
    public interface ISearchRules
    {
        /// <summary>
        /// If set to true, the value will be checked and if empty, an error message will be displayed.
        /// </summary>
        /// <param name="required"></param>
        /// <returns></returns>
        ISearchRules Required(bool required);

        /// <summary>
        /// If set to true, the value will be checked and if this is not a number, an error message will be displayed.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        ISearchRules Number(bool number);

        /// <summary>
        /// If set to true, the value will be checked and if this is not a integer, an error message will be displayed.
        /// </summary>
        /// <param name="integer"></param>
        /// <returns></returns>
        ISearchRules Integer(bool integer);

        /// <summary>
        /// If set, the value will be checked and if the value is less than this, an error message will be displayed.
        /// </summary>
        /// <param name="minValue"></param>
        /// <returns></returns>
        ISearchRules MinValue(int minValue);

        /// <summary>
        /// If set, the value will be checked and if the value is more than this, an error message will be displayed.
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        ISearchRules MaxValue(int maxValue);

        /// <summary>
        /// If set to true, the value will be checked and if this is not valid e-mail, an error message will be displayed
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        ISearchRules Email(bool email);

        /// <summary>
        /// If set to true, the value will be checked and if this is not valid url, an error message will be displayed
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        ISearchRules Url(bool url);

        /// <summary>
        /// If set to true a value from datefmt option is get (if not set ISO date is used) and the value will be checked and if this is not valid date, an error message will be displayed.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        ISearchRules Date(bool date);

        /// <summary>
        /// If set to true, the value will be checked and if this is not valid time, an error message will be displayed. Currently we support only hh:mm format and optional am/pm at the end
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        ISearchRules Time(bool time);

        /// <summary>
        /// If set to true allow definition of the custom checking rules via a custom function.
        /// </summary>
        /// <param name="custom"></param>
        /// <returns></returns>
        ISearchRules Custom(bool custom);

        /// <summary>
        /// This function should be used when a custom option is set to true. Parameters passed to this function are the value, which should be checked and the name - the property from colModel. The function should return array with the following parameters: first parameter - true or false. The value of true mean that the checking is successful false otherwise; the second parameter have sense only if the first value is false and represent the error message which will be displayed to the user. Typically this can look like this [false,”Please enter valid value”]
        /// </summary>
        /// <param name="customFunc"></param>
        /// <returns></returns>
        ISearchRules CustomFunc(string customFunc);
    }
}