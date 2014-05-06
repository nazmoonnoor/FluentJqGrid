using System.Collections.Generic;
using FluentJqGrid.Core.Edit;

namespace FluentJqGrid.Infrastructure.Edit
{
    public class EditSelect : IEditSelect
    {
        private readonly ColumnEditOptions _columnEditOptions;

        internal EditSelect(ColumnEditOptions columnEditOptions)
        {
            _columnEditOptions = columnEditOptions;
        }

        public IEditSelect Value(Dictionary<string, string> value)
        {
            _columnEditOptions.Value = value;
            return this;
        }

        public IEditSelect DataUrl(string dataUrl)
        {
            _columnEditOptions.DataUrl = dataUrl;
            return this;
        }

        public IEditSelect BuildSelect(string buildSelect)
        {
            _columnEditOptions.BuildSelect = buildSelect;
            return this;
        }

        public IEditSelect DataInit(string dataInit)
        {
            _columnEditOptions.DataInit = dataInit;
            return this;
        }

        public IEditSelect DataEvents(string dataEvents)
        {
            _columnEditOptions.DataEvents = dataEvents;
            return this;
        }

        public IEditSelect DefaultValue(string defaultValue)
        {
            _columnEditOptions.DefaultValue = defaultValue;
            return this;
        }

        public IEditSelect NullIfEmpty(bool nullIfEmpty)
        {
            _columnEditOptions.NullIfEmpty = nullIfEmpty;
            return this;
        }

        public IEditSelect Attributs(string attributes)
        {
            _columnEditOptions.Attributes = attributes;
            return this;
        }
    }
}