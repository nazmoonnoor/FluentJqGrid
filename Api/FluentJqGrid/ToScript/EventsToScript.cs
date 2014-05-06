using System.Text;
using FluentJqGrid.Core;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;

namespace FluentJqGrid.ToScript
{
    internal class EventsToScript : ToScriptBase, IToScript
    {
        private readonly Events _events;

        public EventsToScript(Events events)
        {
            _events = events;
        }

        public string ToScript()
        {
            if (_events == null) return string.Empty;
            var sb = new StringBuilder();
            sb.AppendWithLineNonNullOrEmpty("afterInsertRow: {0}, ", _events.AfterInsertRow);
            sb.AppendWithLineNonNullOrEmpty("beforeProcessing: {0}, ", _events.BeforeProcessing);
            sb.AppendWithLineNonNullOrEmpty("beforeRequest: {0}, ", _events.BeforeRequest);
            sb.AppendWithLineNonNullOrEmpty("beforeSelectRow: {0}, ", _events.BeforeSelectRow);
            sb.AppendWithLineNonNullOrEmpty("gridComplete: {0}, ", _events.GridComplete);
            sb.AppendWithLineNonNullOrEmpty("loadBeforeSend: {0}, ", _events.LoadBeforeSend);
            sb.AppendWithLineNonNullOrEmpty("loadComplete: {0}, ", _events.LoadComplete);
            sb.AppendWithLineNonNullOrEmpty("loadError: {0}, ", _events.LoadError);
            sb.AppendWithLineNonNullOrEmpty("onCellSelect: {0}, ", _events.OnCellSelect);
            sb.AppendWithLineNonNullOrEmpty("ondblClickRow: {0}, ", _events.OnDblClickRow);
            sb.AppendWithLineNonNullOrEmpty("onHeaderClick: {0}, ", _events.OnHeaderClick);
            sb.AppendWithLineNonNullOrEmpty("onPaging: {0}, ", _events.OnPaging);
            sb.AppendWithLineNonNullOrEmpty("onRightClickRow: {0}, ", _events.OnRightClickRow);
            sb.AppendWithLineNonNullOrEmpty("onSelectAll: {0}, ", _events.OnSelectAll);
            sb.AppendWithLineNonNullOrEmpty("onSelectRow: {0}, ", _events.OnSelectRow);
            sb.AppendWithLineNonNullOrEmpty("onSortCol: {0}, ", _events.OnSortCol);
            sb.AppendWithLineNonNullOrEmpty("resizeStart: {0}, ", _events.ResizeStart);
            sb.AppendWithLineNonNullOrEmpty("resizeStop: {0}, ", _events.ResizeStop);
            sb.AppendWithLineNonNullOrEmpty("serializeGridData: {0}, ", _events.SerializeGridData);
            return sb.ToString();
        }
    }
}