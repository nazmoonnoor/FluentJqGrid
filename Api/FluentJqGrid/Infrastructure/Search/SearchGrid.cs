using System;
using FluentJqGrid.Core.Search;

namespace FluentJqGrid.Infrastructure.Search
{
    public class SearchGrid : ISearchGrid, IDisposable
    {
        private readonly SearchGridOptions _searchGridOptions;

        internal SearchGrid(SearchGridOptions searchGridOptions)
        {
            _searchGridOptions = searchGridOptions;
        }

        public ISearchGrid AfterShowSearch(string afterShowSearch)
        {
            _searchGridOptions.AfterShowSearch = afterShowSearch;
            return this;
        }

        public ISearchGrid BeforeShowSearch(string beforeShowSearch)
        {
            _searchGridOptions.BeforeShowSearch = beforeShowSearch;
            return this;
        }

        public ISearchGrid CloseAfterSearch(bool? closeAfterSearch)
        {
            _searchGridOptions.CloseAfterSearch = closeAfterSearch;
            return this;
        }

        public ISearchGrid CloseAfterReset(bool? closeAfterReset)
        {
            _searchGridOptions.CloseAfterReset = closeAfterReset;
            return this;
        }

        public ISearchGrid Drag(bool? drag)
        {
            _searchGridOptions.Drag = drag;
            return this;
        }

        public ISearchGrid Resize(bool? resize)
        {
            _searchGridOptions.Resize = resize;
            return this;
        }

        public ISearchGrid Modal(bool? modal)
        {
            _searchGridOptions.Modal = modal;
            return this;
        }

        public ISearchGrid Width(int? width)
        {
            _searchGridOptions.Width = width;
            return this;
        }

        public ISearchGrid Height(string height)
        {
            _searchGridOptions.Height = height;
            return this;
        }

        public ISearchGrid Caption(string caption)
        {
            _searchGridOptions.Caption = caption;
            return this;
        }

        public ISearchGrid ShowQuery(bool? showQuery)
        {
            _searchGridOptions.ShowQuery = showQuery;
            return this;
        }

        public ISearchGrid Find(string find)
        {
            _searchGridOptions.Find = find;
            return this;
        }

        public ISearchGrid MultipleSearch(bool? multipleSearch)
        {
            _searchGridOptions.MultipleSearch = multipleSearch;
            return this;
        }

        public ISearchGrid MultipleGroup(bool? multipleGroup)
        {
            _searchGridOptions.MultipleGroup = multipleGroup;
            return this;
        }

        public ISearchGrid OData(string oData)
        {
            _searchGridOptions.OData = oData;
            return this;
        }

        public ISearchGrid OnClose(string onClose)
        {
            _searchGridOptions.OnClose = onClose;
            return this;
        }

        public ISearchGrid AfterRedraw(string afterRedraw)
        {
            _searchGridOptions.AfterRedraw = afterRedraw;
            return this;
        }

        public ISearchGrid OnSearch(string onSearch)
        {
            _searchGridOptions.OnSearch = onSearch;
            return this;
        }

        public ISearchGrid OnReset(string onReset)
        {
            _searchGridOptions.OnReset = onReset;
            return this;
        }

        public ISearchGrid CloseOnEscape(bool? closeOnEscape)
        {
            _searchGridOptions.CloseOnEscape = closeOnEscape;
            return this;
        }

        public ISearchGrid OnInitializeSearch(string onInitializeSearch)
        {
            _searchGridOptions.OnInitializeSearch = onInitializeSearch;
            return this;
        }

        public ISearchGrid ShowOnLoad(bool? showOnLoad)
        {
            _searchGridOptions.ShowOnLoad = showOnLoad;
            return this;
        }

        public ISearchGrid Errorcheck(bool? errorcheck)
        {
            _searchGridOptions.Errorcheck = errorcheck;
            return this;
        }

        public ISearchGrid Reset(string reset)
        {
            _searchGridOptions.Reset = reset;
            return this;
        }

        public ISearchGrid SField(string sField)
        {
            _searchGridOptions.SField = sField;
            return this;
        }

        public ISearchGrid SFilter(string sFilter)
        {
            _searchGridOptions.SField = sFilter;
            return this;
        }

        public ISearchGrid SOper(string soper)
        {
            _searchGridOptions.SOper = soper;
            return this;
        }

        public ISearchGrid Sopt(string sopt)
        {
            _searchGridOptions.Sopt = sopt;
            return this;
        }

        public ISearchGrid SValue(string sValue)
        {
            _searchGridOptions.SValue = sValue;
            return this;
        }

        public ISearchGrid Overlay(int? overlay)
        {
            _searchGridOptions.Overlay = overlay;
            return this;
        }

        public ISearchGrid Layer(string layer)
        {
            _searchGridOptions.Layer = layer;
            return this;
        }

        public ISearchGrid TmplNames(string tmplNames)
        {
            _searchGridOptions.TmplNames = tmplNames;
            return this;
        }

        public ISearchGrid TmplFilters(string tmplFilters)
        {
            _searchGridOptions.TmplFilters = tmplFilters;
            return this;
        }

        public ISearchGrid TmplLabel(string tmplLabel)
        {
            _searchGridOptions.TmplLabel = tmplLabel;
            return this;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}