namespace FluentJqGrid.Infrastructure.Search
{
    public interface IFilterToolbar
    {
        /// <summary>
        /// Search is performed according to the following rules: for text element when a Enter key is pressed while inputting values and search is performed. For select element when the value changes. The search parameter in grid is set to true and ajax call is made.
        /// </summary>
        /// <param name="autoSearch"></param>
        /// <returns></returns>
        IFilterToolbar AutoSearch(bool autoSearch);

        /// <summary>
        /// event which fires before a search. It is called before triggering the grid. If the event return true triggering does not occur. In this case you can construct your own search parameters and trigger the grid to search the data. Any other return value causes triggering.
        /// </summary>
        /// <param name="beforeSearch"></param>
        /// <returns></returns>
        IFilterToolbar BeforeSearch(string beforeSearch);

        /// <summary>
        /// event which fires after a search
        /// </summary>
        /// <param name="afterSearch"></param>
        /// <returns></returns>
        IFilterToolbar AfterSearch(string afterSearch);

        /// <summary>
        /// event which fires before clearing entered values (i.e.,clearToolbar is activated).It is called before clearing the data from search elements. If the event return true triggering does not occur. In this case you can construct your own search parameters and trigger the grid. Any other return value causes triggering.
        /// </summary>
        /// <param name="beforeClear"></param>
        /// <returns></returns>
        IFilterToolbar BeforeClear(string beforeClear);

        /// <summary>
        /// event which fires after clearing entered values (i.e., clearToolbar activated)
        /// </summary>
        /// <param name="afterClear"></param>
        /// <returns></returns>
        IFilterToolbar AfterClear(string afterClear);

        /// <summary>
        /// Determines how the search should be applied. If this option is true see the autosearch option. If the option is false then the search is performed immediately when the user pres some character
        /// </summary>
        /// <param name="searchOnEnter"></param>
        /// <returns></returns>
        IFilterToolbar SearchOnEnter(bool searchOnEnter);

        /// <summary>
        /// Determines how to post the data on which we perform searching. When the this option is false the posted data is in key:value pair, if the option is true, the posted data is equal on those as in searchGrid method 
        /// </summary>
        /// <param name="stringResult"></param>
        /// <returns></returns>
        IFilterToolbar StringResult(bool stringResult);
        
        /// <summary>
        /// This option is valid only if the option stringReasult is set to true and determines the group operation. Can have values AND and OR.
        /// </summary>
        /// <param name="groupOp"></param>
        /// <returns></returns>
        IFilterToolbar GroupOp(string groupOp);

        /// <summary>
        /// The option determines the default search operator when a search is performed. If any valid option is set, then it will be used for the default operator in all fields. See sopt array here for the available options
        /// </summary>
        /// <param name="defaultSearch"></param>
        /// <returns></returns>
        IFilterToolbar DefaultSearch(string defaultSearch);
    }
}