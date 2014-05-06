namespace FluentJqGrid.Infrastructure.Formatter
{
    public interface IFormatter
    {
        /// <param name="thousandsSeparator">thousandsSeparator determines the separator for the thousands</param>
        /// <param name="defaulValue">defaultValue set the default value if nothing in the data</param>
        void Integer(string thousandsSeparator = null, string defaulValue= null);
        
        /// <param name="decimalSeparator">thousandsSeparator determines the separator for the thousands</param>
        /// <param name="thousandsSeparator">decimalSeparator determines the separator for the decimals</param>
        /// <param name="decimalPlaces">decimalPlaces determine how many decimal places we should have for the number</param>
        /// <param name="defaulValue">defaultValue set the default value if nothing in the data</param>
        void Number(string decimalSeparator=null, string thousandsSeparator=null, string decimalPlaces=null, string defaulValue =null);
        
        /// <param name="decimalSeparator">thousandsSeparator determines the separator for the thousands</param>
        /// <param name="thousandsSeparator">decimalSeparator determines the separator for the decimals</param>
        /// <param name="decimalPlaces">decimalPlaces determine how many decimal places we should have for the number</param>
        /// <param name="defaulValue">defaultValue set the default value if nothing in the data</param>
        /// <param name="prefix">text that is inserted before the number</param>
        /// <param name="suffix">text that is added after the number</param>
        void Currency(string decimalSeparator = null, string thousandsSeparator = null, string decimalPlaces = null, string defaulValue = null, string prefix =null, string suffix =null);

        /// <param name="srcformat">srcformat is the source format - i.e. the format of the date that should be converted</param>
        /// <param name="newformat">newformat is the new output format. The definition of the date format uses the PHP conversions. Also you can use a set of predefined date format - see the mask options in the default date formatting set</param>
        /// <returns></returns>
        void Date(string srcformat  =null, string newformat =null);

        /// <summary>
        /// When a mail type is used we directly add a href with mailto: before the e-mail
        /// </summary>
        void Email();

        /// <param name="target">The default value of the target options is null. When this options is set, we construct a link with the target property set and the cell value put in the href tag.</param>
        void Link(string target);

        /// <param name="baseLinkUrl">baseLinkUrl is the link. </param>
        /// <param name="showAction">showAction is an additional value which is added after the baseLinkUrl. </param>
        /// <param name="addParam">addParam is an additional parameter that can be added after the idName property. </param>
        /// <param name="target">target, if set, is added as an additional attribute. </param>
        /// <param name="idName">idName is the first parameter that is added after the showAction. By default, this is id</param>
        /// <returns></returns>
        void ShowLink(string baseLinkUrl=null, string showAction=null, string addParam = null, string target = null, string idName=null);
        
        /// <param name="disabled">The default value for the disabled is true. This option determines if the checkbox can be changed. If set to false, the values in checkbox can be changed</param>
        void CheckBox(bool? disabled=null);
        
        /// <summary>
        /// this is not a real select but a special case. 
        /// the data should contain the keys, but the value will be displayed in the grid.
        /// </summary>
        void Select();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IFormatActions Actions();
    }
    
    public interface IFormatActions
    {
    }
}