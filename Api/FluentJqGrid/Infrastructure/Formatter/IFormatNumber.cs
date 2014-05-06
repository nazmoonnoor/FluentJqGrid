namespace FluentJqGrid.Infrastructure.Formatter
{
    public interface IFormatNumber
    {
        /// <summary>
        /// DecimalSeparator determines the separator for the decimals
        /// </summary>
        /// <param name="decimalSeparator"></param>
        /// <returns></returns>
        IFormatNumber DecimalSeparator(string decimalSeparator);

        /// <summary>
        /// ThousandsSeparator determines the separator for the thousands
        /// </summary>
        /// <param name="thousandsSeparator"></param>
        /// <returns></returns>
        IFormatNumber ThousandsSeparator(string thousandsSeparator);

        /// <summary>
        /// DecimalPlaces determine how many decimal places we should have for the number
        /// </summary>
        /// <param name="decimalPlaces"></param>
        /// <returns></returns>
        IFormatNumber DecimalPlaces(string decimalPlaces);

        /// <summary>
        /// DefaultValue set the default value if nothing in the data
        /// </summary>
        /// <param name="defaulValue"></param>
        /// <returns></returns>
        IFormatNumber DefaulValue(string defaulValue);
    }
}