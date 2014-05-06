using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Text;
using System.IO;

namespace FluentJqGrid.Mvc4.Demo.Infrastructure
{
    public static class AssetExtensions
    {
        #region Script Helper

        public static MvcHtmlString Script(this HtmlHelper helper, Action<WebAsset> webAssetAction)
        {
            var asset = new WebAsset
                            {
                                Helper = helper,
                                WebAssetType = WebAsset.AssetType.Script
                            };
            webAssetAction(asset);
            return MvcHtmlString.Empty;
        }

        public static MvcHtmlString RenderScripts(this HtmlHelper helper)
        {
            HtmlHelper htmlHelper = helper;
            var url = new UrlHelper(htmlHelper.ViewContext.RequestContext, htmlHelper.RouteCollection);
            var scripts = htmlHelper.ViewContext.HttpContext.Items["client-script-list"] as Dictionary<string, string> ?? new Dictionary<string, string>();
            var scriptBuilder = new StringBuilder();
            foreach (var script in scripts)
            {
                var css = new TagBuilder("script");
                css.MergeAttribute("src", url.Content((script.Value)));
                css.MergeAttribute("type", "text/javascript");
                scriptBuilder.Append(css.ToString());
            }
            return MvcHtmlString.Create(scriptBuilder.ToString());
        }

        #endregion

        #region Style Helper

        public static MvcHtmlString Style(this HtmlHelper helper, Action<WebAsset> webAssetAction)
        {
            var asset = new WebAsset
                            {
                                Helper = helper,
                                WebAssetType = WebAsset.AssetType.Style
                            };
            webAssetAction(asset);
            return MvcHtmlString.Empty;
        }

        public static MvcHtmlString RenderStyles(this HtmlHelper helper)
        {
            HtmlHelper htmlHelper = helper;
            var url = new UrlHelper(htmlHelper.ViewContext.RequestContext, htmlHelper.RouteCollection);
            var styles = htmlHelper.ViewContext.HttpContext.Items["client-style-list"] as Dictionary<string, string> ?? new Dictionary<string, string>();
            var styleBuilder = new StringBuilder();
            foreach (var style in styles)
            {
                var css = new TagBuilder("link");
                css.MergeAttribute("href", url.Content((style.Value)));
                css.MergeAttribute("rel", "stylesheet");
                css.MergeAttribute("type", "text/css");
                styleBuilder.Append(css.ToString());
            }
            return MvcHtmlString.Create(styleBuilder.ToString());
        }

        #endregion
    }

    public class WebAsset
    {
        internal enum AssetType
        {
            Script,
            Style
        }

        internal AssetType WebAssetType { get; set; }
        internal HtmlHelper Helper { get; set; }

        public virtual WebAsset Add(string asset)
        {
            AddToContext(asset);
            return this;
        }

        private void AddToContext(string assetName)
        {
            Dictionary<string, string> assets;
            if (WebAssetType == AssetType.Script)
                assets = Helper.ViewContext.HttpContext.Items["client-script-list"] as Dictionary<string, string> ?? new Dictionary<string, string>();
            else assets = Helper.ViewContext.HttpContext.Items["client-style-list"] as Dictionary<string, string> ?? new Dictionary<string, string>();

            string assetFilePath = Helper.ViewContext.HttpContext.Server.MapPath(assetName);
            if (!File.Exists(assetFilePath)) return;

            var fileInfo = new FileInfo(assetFilePath);

            if (assets.ContainsKey(fileInfo.FullName)) return;

            assets.Add(fileInfo.FullName, assetName);
            if(WebAssetType==AssetType.Script)
                Helper.ViewContext.HttpContext.Items["client-script-list"] = assets;
            else 
                Helper.ViewContext.HttpContext.Items["client-style-list"] = assets;
        }
    }

}