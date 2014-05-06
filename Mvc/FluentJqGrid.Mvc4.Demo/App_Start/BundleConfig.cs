using System;
using System.Web.Optimization;

namespace FluentJqGrid.Mvc4.Demo
{
    public class BundleConfig
    {
        private const string JqgridFolder = "jquery.jqGrid-4.4.1";

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/jquery")
                .Include("~/Scripts/jquery-1.*"));

            bundles.Add(new ScriptBundle("~/Scripts/jqueryui")
                .Include("~/Scripts/jquery-ui*"));

            bundles.Add(new ScriptBundle("~/Scripts/jqueryval")
                .Include("~/Scripts/jquery.unobtrusive*")
                .Include("~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/Scripts/jqgrid")
                .Include("~/Scripts/" + JqgridFolder + "/js/i18n/grid.locale-en.js")
                .Include("~/Scripts/" + JqgridFolder + "/js/jquery.jqGrid.src.js")
                .Include("~/Scripts/" + JqgridFolder + "/src/grid.loader.js*")
                );
            
            bundles.Remove(new ScriptBundle("~/Scripts/jqgridloader")
                .Include("~/Scripts/jquery.jqGrid-4.4.1/src/grid.loader.js"));
            
            bundles.Add(new ScriptBundle("~/Scripts/shjs")
                .Include("~/Scripts/SyntaxHighlighter/shCore.js")
                .Include("~/Scripts/SyntaxHighlighter/shBrushCSharp.js")
                .Include("~/Scripts/SyntaxHighlighter/shBrushJScript.js"));

            bundles.Add(new ScriptBundle("~/Scripts/jqplugins")
                .Include("~/Scripts/organictabs.jquery.js")
                .Include("~/Scripts/menu/simpleverticalmenu.js"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/style.css")
                .Include("~/Content/menu/simpleverticalmenu.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/uiall").Include(
                "~/Content/themes/base/jquery.ui.all.css"));

            bundles.Add(new StyleBundle("~/Scripts/css/jqgrid")
                .Include("~/Scripts/" + JqgridFolder + "/css/ui.jqgrid.css"));

            bundles.Add(new StyleBundle("~/Content/themes/jqgradientca/gca")
                .Include("~/Content/themes/jqgradientca/gradientca.css"));

            bundles.Add(new StyleBundle("~/Content/shcss")
                .Include("~/Content/SyntaxHighlighter/shCore.css")
                .Include("~/Content/SyntaxHighlighter/shThemeRDark.css"));
        }
    }
}