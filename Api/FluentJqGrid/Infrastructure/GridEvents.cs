using System;
using FluentJqGrid.Core;

namespace FluentJqGrid.Infrastructure
{
    public class GridEvents : IGridEvents, IDisposable
    {
        private readonly Events _events;

        internal GridEvents(Events events)
        {
            _events = events;
        }

        public IGridEvents AfterInsertRow(string afterInsertRows)
        {
            _events.AfterInsertRow = afterInsertRows;
            return this;
        }

        public IGridEvents BeforeProcessing(string beforeProcessing)
        {
            _events.BeforeProcessing = beforeProcessing;
            return this;
        }

        public IGridEvents BeforeRequest(string beforeRequest)
        {
            _events.BeforeRequest = beforeRequest;
            return this;
        }

        public IGridEvents BeforeSelectRow(string beforeSelectRow)
        {
            _events.BeforeSelectRow = beforeSelectRow;
            return this;
        }

        public IGridEvents GridComplete(string gridComplete)
        {
            _events.GridComplete = gridComplete;
            return this;
        }

        public IGridEvents LoadBeforeSend(string loadBeforeSend)
        {
            _events.LoadBeforeSend = loadBeforeSend;
            return this;
        }

        public IGridEvents LoadComplete(string loadComplete)
        {
            _events.LoadComplete = loadComplete;
            return this;
        }

        public IGridEvents LoadError(string loadError)
        {
            _events.LoadError = loadError;
            return this;
        }

        public IGridEvents OnCellSelect(string onCellSelect)
        {
            _events.OnCellSelect = onCellSelect;
            return this;
        }

        public IGridEvents OnDblClickRow(string onDblClickRow)
        {
            _events.OnDblClickRow = onDblClickRow;
            return this;
        }

        public IGridEvents OnHeaderClick(string onHeaderClick)
        {
            _events.OnHeaderClick = onHeaderClick;
            return this;
        }

        public IGridEvents OnPaging(string onPaging)
        {
            _events.OnPaging = onPaging;
            return this;
        }

        public IGridEvents OnRightClickRow(string onRightClickRow)
        {
            _events.OnRightClickRow = onRightClickRow;
            return this;
        }

        public IGridEvents OnSelectAll(string onSelectAll)
        {
            _events.OnSelectAll = onSelectAll;
            return this;
        }

        public IGridEvents OnSelectRow(string onSelectRow)
        {
            _events.OnSelectRow = onSelectRow;
            return this;
        }

        public IGridEvents OnSortCol(string onSortCol)
        {
            _events.OnSortCol = onSortCol;
            return this;
        }

        public IGridEvents ResizeStart(string resizeStart)
        {
            _events.ResizeStart = resizeStart;
            return this;
        }

        public IGridEvents ResizeStop(string resizeStop)
        {
            _events.ResizeStop = resizeStop;
            return this;
        }

        public IGridEvents SerializeGridData(string serializeGridData)
        {
            _events.SerializeGridData = serializeGridData;
            return this;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}