using FluentJqGrid.Core.Search;

namespace FluentJqGrid.Infrastructure.Search
{
    class SearchOptions : ISearchOptions
    {
        private readonly ColumnSearchOptions _columnSearchOptions;

        public SearchOptions(ColumnSearchOptions columnSearchOptions)
        {
            _columnSearchOptions = columnSearchOptions;
        }

        public ISearchOptions DataUrl(string dataUrl)
        {
            _columnSearchOptions.DataUrl = dataUrl;
            return this;
        }

        public ISearchOptions BuildSelect(string buildSelect)
        {
            _columnSearchOptions.BuildSelect = buildSelect;
            return this;
        }

        public ISearchOptions DataInit(string dataInit)
        {
            _columnSearchOptions.DataInit = dataInit;
            return this;
        }

        public ISearchOptions DataEvents(string dataEvents)
        {
            _columnSearchOptions.DataEvents = dataEvents;
            return this;
        }

        public ISearchOptions Attr(string attr)
        {
            _columnSearchOptions.Attr = attr;
            return this;
        }

        public ISearchOptions SearchHidden(bool searchHidden)
        {
            _columnSearchOptions.SearchHidden = searchHidden;
            return this;
        }

        public ISearchOptions Sopt(string sopt)
        {
            _columnSearchOptions.Sopt = sopt;
            return this;
        }

        public ISearchOptions DefaultValue(string defaultValue)
        {
            _columnSearchOptions.DefaultValue = defaultValue;
            return this;
        }

        public ISearchOptions Value(string value)
        {
            _columnSearchOptions.Value = value;
            return this;
        }
    }
}