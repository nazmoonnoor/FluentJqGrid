namespace FluentJqGrid.Infrastructure.Formatter
{
    public interface IFormatInteger
    {
        /// <summary>
        ///  Determines the separator for the thousands
        /// </summary>
        /// <param name="thousandsSeparator"></param>
        /// <returns></returns>
        IFormatInteger ThousandsSeparator(string thousandsSeparator);

        /// <summary>
        ///  Set the default value if nothing in the data
        /// </summary>
        /// <param name="defaulValue"></param>
        /// <returns></returns>
        IFormatInteger DefaulValue(string defaulValue);
    }
}