using System;
using System.Collections.Generic;
using FluentJqGrid.Core;

namespace FluentJqGrid.Infrastructure
{
    public class GridInlineEditing : IGridInlineEditing, IDisposable
    {
        private readonly List<InlineEditingOptions> _editingOptionsList;

        internal GridInlineEditing(List<InlineEditingOptions> editingOptionsList)
        {
            _editingOptionsList = editingOptionsList;
        }

        public void AddRow(string buttonId, string initdata = null, string position = null, bool? useDefValues = null, bool? useFormatter = null, string addRowParams = null)
        {
            var editingOptions = new InlineEditingOptions
                                           {
                                               AddRowButtonId = buttonId,
                                               InlineEditType = InlineEditTypes.AddRow,
                                               InitData = initdata,
                                               Position = position,
                                               UseDefValues = useDefValues,
                                               UseFormatter = useFormatter,
                                               AddRowParams = addRowParams
                                           };
            _editingOptionsList.Add(editingOptions);
        }

        public void EditRow(string buttonId, string keys = null, string oneditfunc = null,
            string succesfunc = null, string url = null, string extraparam = null, string aftersavefunc = null, string errorfunc = null, string afterrestorefunc = null)
        {
            var editingOptions = new InlineEditingOptions
                                           {
                                               EditRowButtonId = buttonId,
                                               InlineEditType = InlineEditTypes.EditRow,
                                               Keys = keys,
                                               OnEditFunc = oneditfunc,
                                               SuccessFunc = succesfunc,
                                               Url = url,
                                               ExtraParam = extraparam,
                                               AfterSaveFunc = aftersavefunc,
                                               ErrorFunc = errorfunc,
                                               AfterRestoreFunc = afterrestorefunc
                                           };
            _editingOptionsList.Add(editingOptions);
        }

        public void SaveRow(string buttonId, string succesfunc = null, string url = null, string extraparam = null, string aftersavefunc = null,
            string errorfunc = null, string afterrestorefunc = null)
        {
            var editingOptions = new InlineEditingOptions
                                     {
                                         SaveRowButtonId = buttonId,
                                         InlineEditType = InlineEditTypes.SaveRow,
                                         SuccessFunc = succesfunc,
                                         Url = url,
                                         ExtraParam = extraparam,
                                         AfterSaveFunc = aftersavefunc,
                                         ErrorFunc = errorfunc,
                                         AfterRestoreFunc = afterrestorefunc
                                     };
            _editingOptionsList.Add(editingOptions);
        }

        public void RestoreRow(string buttonId, string afterrestorefunc = null)
        {
            var editingOptions = new InlineEditingOptions
                                     {
                                         RestoreRowButtonId = buttonId,
                                         InlineEditType = InlineEditTypes.RestoreRow,
                                         AfterRestoreFunc = afterrestorefunc
                                     };
            _editingOptionsList.Add(editingOptions);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}