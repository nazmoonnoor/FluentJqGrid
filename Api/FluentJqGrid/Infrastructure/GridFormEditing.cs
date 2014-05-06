using FluentJqGrid.Core;
using FluentJqGrid.Core.Form;
using FluentJqGrid.Infrastructure.Form;
using System;

namespace FluentJqGrid.Infrastructure
{
    public class GridFormEditing : IGridFormEditing, IDisposable
    {
        private readonly FormEditingOptions _formEditingOptions;

        internal GridFormEditing(FormEditingOptions formEditingOptions)
        {
            _formEditingOptions = formEditingOptions;
        }

        public IFormEditBuilder AddGridRow(string buttonId)
        {
            _formEditingOptions.AddGridRowButtonId = buttonId;
            _formEditingOptions.AddGridRow = new FormEditOptions();
            IFormEditBuilder formEditBuilder = new FormEditBuilder(_formEditingOptions.AddGridRow);
            return formEditBuilder;
        }

        public IFormEditBuilder EditGridRow(string buttonId)
        {
            _formEditingOptions.EditGridRowButtonId = buttonId;
            _formEditingOptions.EditGridRow = new FormEditOptions();
            IFormEditBuilder formEditBuilder = new FormEditBuilder(_formEditingOptions.EditGridRow);
            return formEditBuilder;
        }

        public IFormDeleteBuilder DeleteGridRow(string buttonId)
        {
            _formEditingOptions.DeleteGridRowButtonId = buttonId;
            _formEditingOptions.DeleteGridRow = new FormDeleteOptions();
            IFormDeleteBuilder formDeleteBuilder = new FormDeleteBuilder(_formEditingOptions.DeleteGridRow);
            return formDeleteBuilder;
        }

        public IFormViewBuilder ViewGridRow(string buttonId)
        {
            _formEditingOptions.ViewGridRowButtonId = buttonId;
            _formEditingOptions.ViewGridRow = new FormViewOptions();
            IFormViewBuilder formViewBuilder = new FormViewBuilder(_formEditingOptions.ViewGridRow);
            return formViewBuilder;
        }

        public IGridFormEditing Search(string buttonId)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}