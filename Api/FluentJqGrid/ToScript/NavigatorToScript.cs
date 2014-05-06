using System;
using System.Diagnostics.Contracts;
using System.Text;
using FluentJqGrid.Core;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;
using FluentJqGrid.ToScript.Form;
using FluentJqGrid.ToScript.Search;

namespace FluentJqGrid.ToScript
{
    internal class NavigatorToScript : ToScriptBase, IToScript
    {
        private readonly string _gridName;
        private readonly string _pager;
        private readonly NavigatorOptions _navigatorOption;
        
        public NavigatorToScript(string gridName, string pager, NavigatorOptions navigatorOption)
        {
            _gridName = gridName;
            _pager = !pager.StartsWith("#") ?  "#" + pager : pager;
            _navigatorOption = navigatorOption;
        }

        /// <summary>
        /// Generate the Navigation scripts
        /// </summary>
        /// <returns></returns>
        /// $("GridName").navGrid('#gridpager', {{parameters}}, prmEdit, prmAdd, prmDel, prmSearch, prmView);"
        public string ToScript()
        {
            if (_navigatorOption == null) return string.Empty;
            var sb = new StringBuilder();
            if(_navigatorOption.FormNavigator)
            {
                sb.AppendFormat("$(\"#{0}\").jqGrid('navGrid', '{1}',{{}});", _gridName, _pager);
                return sb.ToString();
            }
            sb.AppendFormat("$(\"#{0}\").jqGrid('navGrid', '{1}', {2}, {3}, {4}, {5}, {6}, {7});",
                            _gridName,
                            _pager,
                            SetParameters(_navigatorOption),
                            new FormEditToScript(_navigatorOption.Add).ToScript(),
                            new FormEditToScript(_navigatorOption.Edit).ToScript(),
                            new FormDeleteToScript(_navigatorOption.Delete).ToScript(),
                            new SearchGridToScript(_navigatorOption.Search).ToScript(),
                            new FormViewToScript(_navigatorOption.View).ToScript());
            if(_navigatorOption.InlineNavigator)
                sb.AppendFormat("$('#{0}').jqGrid('inlineNav', '{1}');", _gridName, _pager);
            return sb.ToString();
        }

        public string SetParameters(NavigatorOptions navigatorOptions)
        {
            var sb = new StringBuilder();
            sb.AppendLine().PadLeft(6);
            sb.AppendFormat("{{add: {0}, edit: {1}, del: {2}, search: {3}, view: {4} }}", 
                        ((navigatorOptions.Add != null) ? "true" : "false"),
                        ((navigatorOptions.Edit != null) ? "true" : "false"),
                        ((navigatorOptions.Delete != null) ? "true" : "false"),
                        ((navigatorOptions.Search != null) ? "true" : "false"),
                        ((navigatorOptions.View != null) ? "true" : "false"));

            return sb.ToString();
        }

        private string AccumulateFormSearchOptions(string search)
        {
            return NewLine(6) + "{}";
        }

    }
}