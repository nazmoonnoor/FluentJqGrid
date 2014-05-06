using System;
using FluentJqGrid.Infrastructure.Edit;
using FluentJqGrid.Infrastructure.Form;
using FluentJqGrid.Infrastructure.Search;

namespace FluentJqGrid.Infrastructure
{
    /// <summary>
    /// JqGrid Column builder interface
    /// </summary>
    /// <typeparam name="T">JqGrid Column</typeparam>
    public interface IGridColumnBuilder<T>
    {
        /// <summary>
        /// Defines the alignment of the cell in the Body layer, not in header cell. 
        /// </summary>
        /// <param name="align">Possible values: left, center, right.</param>
        /// <returns></returns>
        IGridColumnBuilder<T> Align(ColumnAlign align);

        /// <summary>
        /// This function add attributes to the cell during the creation of the data - i.e dynamically. By example all valid attributes for the table cell can be used or a style attribute with different properties. The function should return string. Parameters passed to this function are: 
        /// rowId - the id of the row 
        /// val - the value which will be added in the cell 
        /// rawObject - the raw object of the data row - i.e if datatype is json - array, if datatype is xml xml node. 
        /// cm - all the properties of this column listed in the colModel 
        /// rdata - the data row which will be inserted in the row. This parameter is array of type name:value, where name is the name in colModel
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> CellAttribute(string attribute);

        /// <summary>
        /// This option allow to add classes to the column. If more than one class will be used a space should be set. 
        /// By example classes:'class1 class2' will set a class1 and class2 to every cell on that column. In the grid css there is a predefined class ui-ellipsis which allow to attach ellipsis to a particular row. Also this will work in FireFox too.
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Classes(string classes);

        /// <summary>
        /// Governs format of sorttype:date (when datetype is set to local) and editrules {date:true} fields. Determines the expected date format for that column. Uses a PHP-like date formatting. Currently ”/”, ”-”, and ”.” are supported as date separators. Valid formats are: 
        /// y,Y,yyyy for four digits year 
        /// YY, yy for two digits year 
        /// m,mm for months 
        /// d,dd for days. 
        /// </summary>
        /// <param name="dateFormat"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> DateFormat(string dateFormat);

        /// <summary>
        /// The default value for the search field. This option is used only in Custom Searching and will be set as initial search.
        /// </summary>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> DefaultValue(string defaultValue);

        /// <summary>
        /// Defines if the field is editable. This option is used in cell, inline and form modules.
        /// </summary>
        /// <param name="editable"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Editable(bool editable);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="columnEditAction"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> EditOptions(Action<IColumnEdit> columnEditAction);
            
        /// <summary>
        /// Sets additional rules for the editable field editing
        /// </summary>
        /// <param name="editRules"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> EditRules(Action<IEditRules> editRules);

        /// <summary>
        /// If set to asc or desc, the column will be sorted in that direction on first sort.Subsequent sorts of the column will toggle as usual
        /// </summary>
        /// <param name="firstSortOrder"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> FirstSortOrder(string firstSortOrder);

        /// <summary>
        /// If set to true this option does not allow recalculation of the width of the column if shrinkToFit option is set to true. 
        /// Also the width does not change if a setGridWidth method is used to change the grid width.
        /// </summary>
        /// <param name="fixedWidth"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Fixed(bool fixedWidth);

        /// <summary>
        /// Defines various options for form editing.
        /// </summary>
        /// <param name="formOptions"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> FormOptions(Action<IColumnForm> formOptions);

        /// <summary>
        /// Format options can be defined for particular columns, overwriting the defaults from the language file.
        /// </summary>
        /// <param name="formatOptions"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> FormatOptions(string formatOptions);

        /// <summary>
        /// The predefined types (string) or custom function name that controls the format of this field.
        /// </summary>
        /// <param name="formatter"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Formatter(string formatter);

        /// <summary>
        /// If set to true determines that this column will be frozen after calling the setFrozenColumns method
        /// </summary>
        /// <param name="frozen"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Frozen(bool frozen);

        /// <summary>
        /// If set to true this column will not appear in the modal dialog where users can choose which columns to show or hide.
        /// </summary>
        /// <param name="hideInDialog"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> HideInDialog(bool hideInDialog);

        /// <summary>
        /// Defines if this column is hidden at initialization.
        /// </summary>
        /// <param name="hidden"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Hidden(bool hidden);

        /// <summary>
        /// Set the index name when sorting. Passed as sidx parameter.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Index(string index);

        /// <summary>
        /// Defines the json mapping for the column in the incoming json string.
        /// </summary>
        /// <param name="jsonMap"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> JsonMap(string jsonMap);

        /// <summary>
        /// In case if there is no id from server, this can be set as as id for the unique row id. 
        /// Only one column can have this property. If there are more than one key the grid finds the first one and the second is ignored.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Key(bool key);

        /// <summary>
        /// When colNames array is empty, defines the heading for this column. If both the colNames array and this setting are empty, the heading for this column comes from the name property.
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Label(string label);

        /// <summary>
        /// Defines if the column can be re sized
        /// </summary>
        /// <param name="resizable"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Resizable(bool resizable);

        /// <summary>
        /// When used in search modules, disables or enables searching on that column. 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Search(bool search);

        /// <summary>
        /// Defines the search options used searching Search Configuration
        /// </summary>
        /// <param name="searchOptionsAction"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> SearchOptions(Action<ISearchOptions> searchOptionsAction);

        /// <summary>
        /// Defines the search rules used searching Search Configuration
        /// </summary>
        /// <param name="searchRulesAction"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> SearchRules(Action<ISearchRules> searchRulesAction);

        /// <summary>
        /// Defines is this can be sorted.
        /// </summary>
        /// <param name="sortable"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Sortable(bool sortable);

        /// <summary>
        /// Used when datatype is local. Defines the type of the column for appropriate sorting.Possible values: 
        /// int/integer - for sorting integer 
        /// float/number/currency - for sorting decimal numbers 
        /// date - for sorting date 
        /// text - for text sorting 
        /// function - defines a custom function for sorting. To this function we pass the value to be sorted and it should return a value too. 
        /// </summary>
        /// <param name="sortType"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> SortType(ColumnSortType sortType);

        /// <summary>
        /// Determines the type of the element when searching.
        /// </summary>
        /// <param name="searchType"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> SearchType(string searchType);

        /// <summary>
        /// Valid only in Custom Searching and edittype : 'select' and describes the url from where we can get already-constructed select element
        /// </summary>
        /// <param name="surl"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> SUrl(string surl);

        /// <summary>
        /// Set of valid properties for the colModel. This option can be used if you want to overwrite a lot of default values in the column model with easy. See cmTemplate in grid options
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Template(string template);

        /// <summary>
        /// If this option is false the title is not displayed in that column when we hover a cell with the mouse
        /// </summary>
        /// <param name="titleOnHover"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> TitleOnHover(bool titleOnHover);

        /// <summary>
        /// Set the initial width of the column, in pixels. This value currently can not be set as percentage
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Width(int width);

        /// <summary>
        /// Defines the xml mapping for the column in the incomming xml file. Use a CCS specification for this 
        /// </summary>
        /// <param name="xmlMap"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> XmlMap(string xmlMap);

        /// <summary>
        /// Custom function to “unformat” a value of the cell when used in editing See Custom Formatter. (Unformat is also called during sort operations. The value returned by unformat is the value compared during the sort.)
        /// </summary>
        /// <param name="unFormat"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> UnFormat(string unFormat);

        /// <summary>
        /// This option is valid only when viewGridRow method is activated. When the option is set to false the column does not appear in view Form
        /// </summary>
        /// <param name="viewable"></param>
        /// <returns></returns>
        IGridColumnBuilder<T> Viewable(bool viewable);

        /// <summary>
        /// Sets the JqGrid column header
        /// </summary>
        /// <param name="header">JqGrid column header</param>
        /// <returns></returns>
        IGridColumnBuilder<T> Header(string header);
    }
}

