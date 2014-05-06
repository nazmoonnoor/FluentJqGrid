using FluentJqGrid.Infrastructure.Form;

namespace FluentJqGrid.Infrastructure
{
    public interface IGridFormEditing
    {
        /// <summary>
        /// Enable Add button
        /// </summary>
        /// <param name="buttonId">Id of the button</param>
        /// <returns></returns>
        IFormEditBuilder AddGridRow(string buttonId);

        /// <summary>
        /// Enable Edit
        /// </summary>
        /// <param name="buttonId">Id of the button</param>
        /// <returns></returns>
        IFormEditBuilder EditGridRow(string buttonId);

        /// <summary>
        /// Enable Delete
        /// </summary>
        /// <param name="buttonId">Id of the button</param>
        /// <returns></returns>
        IFormDeleteBuilder DeleteGridRow(string buttonId);

        /// <summary>
        /// Enable View
        /// </summary>
        /// <param name="buttonId">Id of the button</param>
        /// <returns></returns>
        IFormViewBuilder ViewGridRow(string buttonId);

        /// <summary>
        /// Enable Search
        /// </summary>
        /// <param name="buttonId">Id of the button</param>
        /// <returns></returns>
        IGridFormEditing Search(string buttonId);
    }
}