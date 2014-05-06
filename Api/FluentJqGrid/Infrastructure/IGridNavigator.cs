using FluentJqGrid.Infrastructure.Form;
using FluentJqGrid.Infrastructure.Search;

namespace FluentJqGrid.Infrastructure
{
    public interface IGridNavigator
    {
        /// <summary>
        /// Enable Add button on navigator
        /// </summary>
        /// <returns></returns>
        IFormEditBuilder Add();

        /// <summary>
        /// Enable Edit button on navigator
        /// </summary>
        /// <returns></returns>
        IFormEditBuilder Edit();

        /// <summary>
        /// Enable Delete button on navigator
        /// </summary>
        /// <returns></returns>
        IFormDeleteBuilder Delete();

        /// <summary>
        /// Enable View button on navigator
        /// </summary>
        /// <returns></returns>
        IFormViewBuilder View();

        /// <summary>
        /// Enable Search button on navigator
        /// </summary>
        /// <returns></returns>
        ISearchGrid Search();

        /// <summary>
        /// Included feature from JqGrid 4.3 or later.
        /// Enable inline editing options in navigator. 
        /// </summary>
        void InlineNavigator();

        /// <summary>
        /// Enable form editing options in navigator. 
        /// </summary>
        void FormNavigator();
    }
}