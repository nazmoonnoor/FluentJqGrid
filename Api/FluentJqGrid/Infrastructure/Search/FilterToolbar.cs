using System;
using FluentJqGrid.Core.Search;

namespace FluentJqGrid.Infrastructure.Search
{
    public class FilterToolbar : IFilterToolbar, IDisposable
    {
        private readonly FilterToolbarOptions _filterToolbarOptions;

        internal FilterToolbar(FilterToolbarOptions filterToolbarOptions)
        {
            _filterToolbarOptions = filterToolbarOptions;
        }

        public IFilterToolbar AutoSearch(bool autoSearch)
        {
            _filterToolbarOptions.AutoSearch = autoSearch;
            return this;
        }

        public IFilterToolbar BeforeSearch(string beforeSearch)
        {
            _filterToolbarOptions.BeforeSearch = beforeSearch;
            return this;
        }

        public IFilterToolbar AfterSearch(string afterSearch)
        {
            _filterToolbarOptions.AfterSearch = afterSearch;
            return this;
        }

        public IFilterToolbar BeforeClear(string beforeClear)
        {
            _filterToolbarOptions.BeforeClear = beforeClear;
            return this;
        }

        public IFilterToolbar AfterClear(string afterClear)
        {
            _filterToolbarOptions.AfterClear = afterClear;
            return this;
        }

        public IFilterToolbar SearchOnEnter(bool searchOnEnter)
        {
            _filterToolbarOptions.SearchOnEnter = searchOnEnter;
            return this;
        }

        public IFilterToolbar StringResult(bool stringResult)
        {
            _filterToolbarOptions.StringResult = stringResult;
            return this;
        }

        public IFilterToolbar GroupOp(string groupOp)
        {
            _filterToolbarOptions.GroupOp = groupOp;
            return this;
        }

        public IFilterToolbar DefaultSearch(string defaultSearch)
        {
            _filterToolbarOptions.DefaultSearch = defaultSearch;
            return this;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}