namespace FluentJqGrid.Infrastructure.Formatter
{
    public interface IFormatShowLink
    {
        /// <summary>
        /// BaseLinkUrl is the link. 
        /// </summary>
        /// <param name="baseLinkUrl"></param>
        /// <returns></returns>
        IFormatShowLink BaseLinkUrl(string baseLinkUrl);

        /// <summary>
        /// ShowAction is an additional value which is added after the baseLinkUrl. 
        /// </summary>
        /// <param name="showAction"></param>
        /// <returns></returns>
        IFormatShowLink ShowAction(string showAction);

        /// <summary>
        /// AddParam is an additional parameter that can be added after the idName property. 
        /// </summary>
        /// <param name="addParam"></param>
        /// <returns></returns>
        IFormatShowLink AddParam(string addParam);

        /// <summary>
        /// Target, if set, is added as an additional attribute. 
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        IFormatShowLink Target(string target);

        /// <summary>
        /// idName is the first parameter that is added after the showAction. By default, this is id,
        /// </summary>
        /// <param name="idName"></param>
        /// <returns></returns>
        IFormatShowLink IDName(string idName);
    }
}