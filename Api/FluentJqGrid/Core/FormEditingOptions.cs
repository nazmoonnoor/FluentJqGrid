using FluentJqGrid.Core.Form;

namespace FluentJqGrid.Core
{
    internal class FormEditingOptions
    {
        internal FormEditOptions AddGridRow { get; set; }

        internal FormEditOptions EditGridRow { get; set; }

        internal FormDeleteOptions DeleteGridRow { get; set; }

        internal FormViewOptions ViewGridRow { get; set; }

        internal string Search { get; set; }

        internal string AddGridRowButtonId { get; set; }
        internal string EditGridRowButtonId { get; set; }
        internal string DeleteGridRowButtonId { get; set; }
        internal string ViewGridRowButtonId { get; set; }
        internal string SearchButtonId { get; set; }
    }
}