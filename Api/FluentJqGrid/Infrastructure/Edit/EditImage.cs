using FluentJqGrid.Core.Edit;

namespace FluentJqGrid.Infrastructure.Edit
{
    public class EditImage : IEditImage
    {
        private readonly ColumnEditOptions _columnEditOptions;

        internal EditImage(ColumnEditOptions columnEditOptions)
        {
            _columnEditOptions = columnEditOptions;
        }

        public IEditImage Src(string src)
        {
            _columnEditOptions.ImageSrc = src;
            return this;
        }

        public IEditImage DataInit(string dataInit)
        {
            _columnEditOptions.DataInit = dataInit;
            return this;
        }

        public IEditImage DataEvents(string dataEvents)
        {
            _columnEditOptions.DataEvents = dataEvents;
            return this;
        }

        public IEditImage DefaultValue(string defaultValue)
        {
            _columnEditOptions.DefaultValue = defaultValue;
            return this;
        }

        public IEditImage NullIfEmpty(bool nullIfEmpty)
        {
            _columnEditOptions.NullIfEmpty = nullIfEmpty;
            return this;
        }

        public IEditImage Attributes(string attributes)
        {
            _columnEditOptions.Attributes = attributes;
            return this;
        }
    }
}