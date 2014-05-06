using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using FluentJqGrid.Core;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;
using FluentJqGrid.ToScript.Search;

namespace FluentJqGrid.ToScript
{
    internal class ToScriptManager : ToScriptBase, IToScript
    {
        private readonly GridOptions _gridOptions;
        private readonly bool _renderGridHtml;
        
        public ToScriptManager(GridOptions gridOptions, bool renderGridHtml)
        {
            _gridOptions = gridOptions;
            _renderGridHtml = renderGridHtml;
        }

        public string ToScript()
        {
            try
            {
                var sb = new StringBuilder();

                //TODO: check for basic config. like if the name, url, datatype etc are given or not

                sb.AppendFormat("$({0}).jqGrid({{ ", Asq("#" + _gridOptions.Name))
                    .AppendWithLineNonNullOrEmpty("url: {0}, ", Asq(_gridOptions.Url))
                    .AppendWithLineNonNullOrEmpty("datatype: {0}, ", Asq(_gridOptions.DataType))
                    .AppendWithLineNonNullOrEmpty("mtype: {0}, ", Asq(_gridOptions.MType))
                    .Append(new ColumnToScript(_gridOptions).ToScript())
                    .AppendWithLineNonNullOrEmpty("ajaxGridOptions: {0},", _gridOptions.AjaxGridOptions)
                    .AppendWithLineNonNullOrEmpty("ajaxSelectOptions: {0},", _gridOptions.AjaxSelectOptions)
                    .AppendWithLineNonNullOrEmpty("altclass: {0}, ", Asq(_gridOptions.AltClass))
                    .AppendWithLineNonNullOrEmpty("altRows: {0},", ToLowerString(_gridOptions.AltRows))
                    .AppendWithLineNonNullOrEmpty("autoencode: {0},", ToLowerString(_gridOptions.AutoEncode))
                    .AppendWithLineNonNullOrEmpty("autowidth: {0},", ToLowerString(_gridOptions.AutoWidth))
                    .AppendWithLineNonNullOrEmpty("caption: {0}, ", Asq(_gridOptions.Caption))
                    .AppendWithLineNonNullOrEmpty("cellLayout: {0},", _gridOptions.CellLayout)
                    .AppendWithLineNonNullOrEmpty("cellEdit: {0},", ToLowerString(_gridOptions.CellEdit))
                    .AppendWithLineNonNullOrEmpty("cellsubmit: {0}, ", Asq(GetCellSumbitType(_gridOptions.CellSubmit)))
                    .AppendWithLineNonNullOrEmpty("cellurl: {0}, ", Asq(_gridOptions.CellUrl))
                    .AppendWithLineNonNullOrEmpty("cmTemplate: {0},", _gridOptions.CmTemplate)
                    .AppendWithLineNonNullOrEmpty("data: {0},", _gridOptions.Data)
                    .AppendWithLineNonNullOrEmpty("datastr: {0},", _gridOptions.DataStr)
                    .AppendWithLineNonNullOrEmpty("deepempty: {0},",ToLowerString(_gridOptions.DeepEmpty))
                    .AppendWithLineNonNullOrEmpty("deselectAfterSort: {0},", ToLowerString(_gridOptions.DeselectAfterSort))
                    .AppendWithLineNonNullOrEmpty("direction: {0}, ", Asq(_gridOptions.Direction))
                    .AppendWithLineNonNullOrEmpty("direction: {0}, ", Asq(_gridOptions.Direction))
                    .AppendWithLineNonNullOrEmpty("editurl: {0}, ", Asq(_gridOptions.EditUrl))
                    .AppendWithLineNonNullOrEmpty("emptyrecords: {0}, ", Asq(_gridOptions.EmptyRecords))
                    .AppendWithLineNonNullOrEmpty("ExpandColClick: {0}, ", ToLowerString(_gridOptions.ExpandColClick))
                    .AppendWithLineNonNullOrEmpty("ExpandColumn: {0}, ", Asq(_gridOptions.ExpandColumn))
                    .AppendWithLineNonNullOrEmpty("footerrow: {0}, ", ToLowerString(_gridOptions.FooterRow))
                    .AppendWithLineNonNullOrEmpty("forceFit: {0}, ", ToLowerString(_gridOptions.ForceFit))
                    .AppendWithLineNonNullOrEmpty("gridstate: {0}, ", Asq(_gridOptions.GridState))
                    .AppendWithLineNonNullOrEmpty("gridview: {0}, ", ToLowerString(_gridOptions.GridView))
                    .AppendWithLineNonNullOrEmpty("grouping: {0}, ", ToLowerString(_gridOptions.Grouping))
                    .AppendWithLineNonNullOrEmpty("headertitles: {0}, ", ToLowerString(_gridOptions.HeaderTitles))
                    .AppendWithLineNonNullOrEmpty("height: {0}, ", !string.IsNullOrEmpty(_gridOptions.Height) ? ((_gridOptions.Height.EndsWith("%")) ? Asq(_gridOptions.Height) : _gridOptions.Height) : null)
                    .AppendWithLineNonNullOrEmpty("hiddengrid: {0}, ", ToLowerString(_gridOptions.HiddenGrid))
                    .AppendWithLineNonNullOrEmpty("hidegrid: {0}, ", ToLowerString(_gridOptions.HideGrid))
                    .AppendWithLineNonNullOrEmpty("hoverrows: {0}, ", ToLowerString(_gridOptions.HoverRows))
                    .AppendWithLineNonNullOrEmpty("idPrefix: {0}, ", !string.IsNullOrEmpty(_gridOptions.IdPrefix) ? ((_gridOptions.Height.EndsWith("%")) ? Asq(_gridOptions.Height) : _gridOptions.Height) : null)
                    .AppendWithLineNonNullOrEmpty("ignoreCase: {0}, ", ToLowerString(_gridOptions.IgnoreCase))
                    .AppendWithLineNonNullOrEmpty("imgpath: {0}, ", Asq(_gridOptions.ImgPath))
                    .AppendWithLineNonNullOrEmpty("inlineData: {0}, ", Asq(_gridOptions.InlineData))
                    .AppendWithLineNonNullOrEmpty("jsonReader: {0}, ", _gridOptions.JsonReader)
                    .AppendWithLineNonNullOrEmpty("lastpage: {0},", _gridOptions.LastPage)
                    .AppendWithLineNonNullOrEmpty("lastsort: {0}, ", _gridOptions.LastSort)
                    .AppendWithLineNonNullOrEmpty("loadonce: {0}, ", ToLowerString(_gridOptions.LoadOnce))
                    .AppendWithLineNonNullOrEmpty("loadtext: {0}, ", Asq(_gridOptions.LoadText))
                    .AppendWithLineNonNullOrEmpty("loadui: {0}, ", Asq(_gridOptions.LoadUi))
                    .AppendWithLineNonNullOrEmpty("multikey: {0}, ", Asq(_gridOptions.MultiKey))
                    .AppendWithLineNonNullOrEmpty("multiboxonly: {0}, ", ToLowerString(_gridOptions.MultiBoxOnly))
                    .AppendWithLineNonNullOrEmpty("multiselect: {0}, ", ToLowerString(_gridOptions.MultiSelect))
                    .AppendWithLineNonNullOrEmpty("multiselectWidth: {0}, ", _gridOptions.MultiSelectWidth)
                    .AppendWithLineNonNullOrEmpty("page: {0}, ", Asq(_gridOptions.Page))
                    .AppendWithLineNonNullOrEmpty("pager: {0}, ", Asq(_gridOptions.Pager))
                    .AppendWithLineNonNullOrEmpty("pagerpos: {0}, ", Asq(_gridOptions.PagerPosition))
                    .AppendWithLineNonNullOrEmpty("pgbuttons: {0}, ", ToLowerString(_gridOptions.PgButtons))
                    .AppendWithLineNonNullOrEmpty("pginput: {0}, ", ToLowerString(_gridOptions.PgInput))
                    .AppendWithLineNonNullOrEmpty("pgtext: {0}, ", Asq(_gridOptions.PgText))
                    .AppendWithLineNonNullOrEmpty("prmNames: {0}, ", _gridOptions.PrmNames)
                    .AppendWithLineNonNullOrEmpty("postData: {0}, ", _gridOptions.PostData)
                    .AppendWithLineNonNullOrEmpty("reccount: {0}, ", _gridOptions.Reccount)
                    .AppendWithLineNonNullOrEmpty("recordpos: {0}, ", Asq(_gridOptions.RecordPosition))
                    .AppendWithLineNonNullOrEmpty("records: {0}, ", _gridOptions.Records)
                    .AppendWithLineNonNullOrEmpty("recordtext: {0}, ", Asq(_gridOptions.RecordText))
                    .AppendWithLineNonNullOrEmpty("resizeclass: {0}, ", Asq(_gridOptions.ResizeClass))
                    .AppendWithLineNonNullOrEmpty("rowList: {0},", GetRowList(_gridOptions.RowList))
                    .AppendWithLineNonNullOrEmpty("rownumbers: {0}, ", ToLowerString(_gridOptions.RowNumbers))
                    .AppendWithLineNonNullOrEmpty("rowNum: {0},", _gridOptions.RowNum)
                    .AppendWithLineNonNullOrEmpty("rowTotal: {0}, ", _gridOptions.RowTotal)
                    .AppendWithLineNonNullOrEmpty("rownumWidth: {0}, ", _gridOptions.RowNumWidth)
                    .AppendWithLineNonNullOrEmpty("savedRow: {0}, ", _gridOptions.SavedRow)
                    .AppendWithLineNonNullOrEmpty("scroll: {0}, ", ToLowerString(_gridOptions.Scroll))
                    .AppendWithLineNonNullOrEmpty("scrollOffset: {0}, ", _gridOptions.ScrollOffset)
                    .AppendWithLineNonNullOrEmpty("scrollTimeout: {0}, ", _gridOptions.ScrollTimeout)
                    .AppendWithLineNonNullOrEmpty("scrollrows: {0}, ", ToLowerString(_gridOptions.ScrollRows))
                    .AppendWithLineNonNullOrEmpty("selarrrow: {0}, ", _gridOptions.SelArrrow)
                    .AppendWithLineNonNullOrEmpty("selrow: {0}, ", Asq(_gridOptions.SelRow))
                    .AppendWithLineNonNullOrEmpty("shrinkToFit: {0}, ", ToLowerString(_gridOptions.ShrinkToFit))
                    .AppendWithLineNonNullOrEmpty("sortable: {0}, ", ToLowerString(_gridOptions.Sortable))
                    .AppendWithLineNonNullOrEmpty("sortname: {0}, ", Asq(_gridOptions.SortName))
                    .AppendWithLineNonNullOrEmpty("sortorder: {0}, ", Asq(_gridOptions.SortOrder))
                    //subgrid and toolbar
                    .AppendWithLineNonNullOrEmpty("toppager: {0}, ", ToLowerString(_gridOptions.TopPager))
                    .AppendWithLineNonNullOrEmpty("totaltime: {0}, ", _gridOptions.TotalTime)
                    //treegrid
                    .AppendWithLineNonNullOrEmpty("userData: {0}, ", _gridOptions.UserData)
                    .AppendWithLineNonNullOrEmpty("userDataOnFooter: {0}, ", ToLowerString(_gridOptions.UserDataOnFooter))
                    .AppendWithLineNonNullOrEmpty("viewrecords: {0},", ToLowerString(_gridOptions.ViewRecords))
                    .AppendWithLineNonNullOrEmpty("viewsortcols: {0}, ", _gridOptions.ViewSortCols)
                    .AppendWithLineNonNullOrEmpty("width: {0}, ", !string.IsNullOrEmpty(_gridOptions.Width) ? ((_gridOptions.Width.EndsWith("%")) ? Asq(_gridOptions.Width) : _gridOptions.Width) : null)
                    .AppendWithLineNonNullOrEmpty("xmlReader: {0}, ", _gridOptions.XmlReader)
                    .AppendLine(new EventsToScript(_gridOptions.Events).ToScript())
                    .RemoveLast(COMMA)
                    .AppendLine("});")

                    //Outside the grid
                    .AppendLine(new NavigatorToScript(_gridOptions.Name, _gridOptions.Pager, _gridOptions.NavigatorOptions).ToScript())
                    .AppendLine(new FormEditingToScript(_gridOptions.Name, _gridOptions.FormEditingOptions).ToScript())
                    .AppendLine(new InlineEditingToScript(_gridOptions.Name, _gridOptions.InlineEditingOptions).ToScript())
                    .AppendLine(new FilterToolbarToScript(_gridOptions.Name, _gridOptions.FilterToolbar).ToScript())
                    .AppendLine(new SearchGridToScript(_gridOptions.Name, _gridOptions.SearchGrid).ToScript());

                string html = string.Format(@"<table id={0}></table>
                                          <div id={1}></div>",
                                            Asq(_gridOptions.Name), Asq(_gridOptions.Pager));
                string script = string.Format(
                    @"{0} {1}", sb, NewLine(0));
                //@"$(function() {{{0} {1} {2}}});", NewLine(3), sb, NewLine(0));
                script = string.Format(SCRIPT_TAG, script);
                string render = (_renderGridHtml) ? html + script : script;
                return render;
            }
            catch (Exception ex)
            {
                string error = string.Format(@"<div>
                                  Error occurred: <br />
                                  Message: {0} <br /><br />
                                  Stack trace: {1}
                                 </div>", ex.Message, ex.StackTrace);

                return error;
            }
        }
    }
}


/*Exceptions:
 * jsonReader: doesn't use Asq() method
 * prmNames: doesn't use Asq() method
 * postData: doesn't use Asq() method
 * selarrrow: doesn't use Asq() method
 * userData: doesn't use Asq() method
 * viewsortcols: doesn't use Asq() method
 * xmlReader: doesn't use Asq() method
*/