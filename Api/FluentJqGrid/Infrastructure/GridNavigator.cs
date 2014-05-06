using System;
using FluentJqGrid.Core;
using FluentJqGrid.Core.Form;
using FluentJqGrid.Core.Search;
using FluentJqGrid.Infrastructure.Form;
using FluentJqGrid.Infrastructure.Search;

namespace FluentJqGrid.Infrastructure
{
    public class GridNavigator : IGridNavigator, IDisposable
    {
        private readonly NavigatorOptions _navigatorOptions;

        internal GridNavigator(NavigatorOptions navigatorOptions)
        {
            _navigatorOptions = navigatorOptions;
        }

        public IFormEditBuilder Add()
        {
            _navigatorOptions.Add = new FormEditOptions();
            IFormEditBuilder formEditBuilder = new FormEditBuilder(_navigatorOptions.Add);
            return formEditBuilder;
        }

        public IFormEditBuilder Edit()
        {
            _navigatorOptions.Edit = new FormEditOptions();
            IFormEditBuilder formEditBuilder = new FormEditBuilder(_navigatorOptions.Edit);
            return formEditBuilder;
        }

        public IFormDeleteBuilder Delete()
        {
            _navigatorOptions.Delete = new FormDeleteOptions();
            IFormDeleteBuilder formDeleteBuilder = new FormDeleteBuilder(_navigatorOptions.Delete);
            return formDeleteBuilder;
        }

        public IFormViewBuilder View()
        {
            _navigatorOptions.View = new FormViewOptions();
            IFormViewBuilder formViewBuilder = new FormViewBuilder(_navigatorOptions.View);
            return formViewBuilder;
        }

        public ISearchGrid Search()
        {
            _navigatorOptions.Search = new SearchGridOptions();
            ISearchGrid searchGrid = new SearchGrid(_navigatorOptions.Search);
            return searchGrid;
        }

        public void InlineNavigator()
        {
            _navigatorOptions.InlineNavigator = true;
        }

        public void FormNavigator()
        {
            _navigatorOptions.FormNavigator = true;
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
