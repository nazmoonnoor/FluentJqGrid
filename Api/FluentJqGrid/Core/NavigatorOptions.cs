using FluentJqGrid.Core.Form;
using FluentJqGrid.Core.Search;

namespace FluentJqGrid.Core
{
    internal class NavigatorOptions
    {
        internal FormEditOptions Add { get; set; }

        internal FormEditOptions Edit { get; set; }

        internal FormDeleteOptions Delete { get; set; }

        internal FormViewOptions View { get; set; }

        internal SearchGridOptions Search { get; set; }

        internal bool InlineNavigator { get; set; }

        internal bool FormNavigator { get; set; }
    }
}