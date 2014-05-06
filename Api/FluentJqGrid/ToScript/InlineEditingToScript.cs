using System.Collections.Generic;
using System.Text;
using FluentJqGrid.Core;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;

namespace FluentJqGrid.ToScript
{
    internal class InlineEditingToScript : ToScriptBase, IToScript
    {
        private readonly string _gridName;
        private readonly List<InlineEditingOptions> _editingOptionsList;

        internal InlineEditingToScript(string gridName, List<InlineEditingOptions> editingOptionsList)
        {
            _gridName = gridName;
            _editingOptionsList = editingOptionsList;
        }

        public string ToScript()
        {
            if (_editingOptionsList == null) return string.Empty;
            var sb = new StringBuilder();

            _editingOptionsList.ForEach(e=>GetInlineEditBuilder(sb, e));

            return sb.ToString();
        }

        public string GetInlineEditBuilder(StringBuilder sb, InlineEditingOptions editingOptions)
        {
            string parameters = SetParameters(editingOptions);
            
            switch (editingOptions.InlineEditType)
            {
                //case InlineEditTypes.AddRow:
                //    sb.AppendFormat("$(\"#{0}\").click(function(){{" +
                //    "{1}$(\"#{2}\").jqGrid('addRow', {{ {3} }});" +
                //    "{4}}});",
                //    editingOptions.AddRowButtonId,
                //    NewLine(6),
                //    _gridName,
                //    parameters,
                //    NewLine(0)).AppendLine(); 
                //    break;
                case InlineEditTypes.AddRow:
                    sb.AppendFormat("$(\"#{0}\").click(function(){{" +
                    "{1}$(\"#{2}\").jqGrid('addRow', 'new_row');" +
                    "{3}}});",
                    editingOptions.AddRowButtonId,
                    NewLine(6),
                    _gridName,
                    NewLine(0)).AppendLine();
                    break;
                //case InlineEditTypes.EditRow:
                //    sb.AppendFormat("$(\"#{0}\").click(function(){{" +
                //    "{1}var gr = $(\"#{2}\").jqGrid('getGridParam','selrow');" +
                //    "{1}if( gr != null ) $(\"#{2}\").jqGrid('editRow', gr, {{ {3} }});" +
                //    "{1}else alert('Please Select Row');" +
                //    "{4}}});",
                //    editingOptions.EditRowButtonId,
                //    NewLine(6),
                //    _gridName,
                //    parameters,
                //    NewLine(0)).AppendLine();
                //    break;
                case InlineEditTypes.EditRow:
                    sb.AppendFormat("$(\"#{0}\").click(function(){{" +
                    "{1}var gr = $(\"#{2}\").jqGrid('getGridParam','selrow');" +
                    "{1}if( gr != null ) $(\"#{2}\").jqGrid('editRow', gr, false);" +
                    "{1}else alert('Please Select Row');" +
                    "{3}}});",
                    editingOptions.EditRowButtonId,
                    NewLine(6),
                    _gridName,
                    NewLine(0)).AppendLine();
                    break;
                //case InlineEditTypes.SaveRow:
                //    sb.AppendFormat("$(\"#{0}\").click(function(){{" +
                //    "{1}var gr = $(\"#{2}\").jqGrid('getGridParam','selrow');" +
                //    "{1}if( gr != null ) $(\"#{2}\").jqGrid('saveRow', gr, {{ {3} }} );" +
                //    "{1}else alert('Please Select Row');" +
                //    "{4}}});",
                //    editingOptions.SaveRowButtonId,
                //    NewLine(6),
                //    _gridName,
                //    parameters,
                //    NewLine(0)).AppendLine();
                //    break;
                case InlineEditTypes.SaveRow:
                    sb.AppendFormat("$(\"#{0}\").click(function(){{" +
                    "{1}var gr = $(\"#{2}\").jqGrid('getGridParam','selrow');" +
                    "{1}if( gr != null ) $(\"#{2}\").jqGrid('saveRow', gr, successfn );" +
                    "{1}else alert('Please Select Row');" +
                    "{3}}});",
                    editingOptions.SaveRowButtonId,
                    NewLine(6),
                    _gridName,
                    NewLine(0)).AppendLine();
                    break;
                case InlineEditTypes.RestoreRow:
                    sb.AppendFormat("$(\"#{0}\").click(function(){{" +
                    "{1}var gr = $(\"#{2}\").jqGrid('getGridParam','selrow');" +
                    "{1}if( gr != null ) $(\"#{2}\").jqGrid('restoreRow', gr, {{ {3} }});" +
                    "{1}else alert('Please Select Row');" +
                    "{4}}});",
                    editingOptions.RestoreRowButtonId,
                    NewLine(6),
                    _gridName,
                    parameters,
                    NewLine(0)).AppendLine();
                    break;
            }
            return sb.ToString();
        }

        private string SetParameters(InlineEditingOptions editingOptions)
        {
            var sb = new StringBuilder();
            sb.AppendWithLineNonNullOrEmpty("\"key\": {0},", editingOptions.Keys)
                .AppendWithLineNonNullOrEmpty("\"initdata\": {0},", editingOptions.InitData)
                .AppendWithLineNonNullOrEmpty("\"position\": {0},", Asq(editingOptions.Position))
                .AppendWithLineNonNullOrEmpty("\"url\": {0},", Asq(editingOptions.Url))
                .AppendWithLineNonNullOrEmpty("\"extraparam\": {0},", editingOptions.ExtraParam)
                .AppendWithLineNonNullOrEmpty("\"useDefValues\": {0},", ToLowerString(editingOptions.UseDefValues))
                .AppendWithLineNonNullOrEmpty("\"useFormatter\": {0},", ToLowerString(editingOptions.UseFormatter))
                .AppendWithLineNonNullOrEmpty("\"addRowParams\": {0},", editingOptions.AddRowParams)
                .AppendWithLineNonNullOrEmpty("oneditfunc: {0},", editingOptions.OnEditFunc)
                .AppendWithLineNonNullOrEmpty("\"successfunc\": {0},", editingOptions.SuccessFunc)
                .AppendWithLineNonNullOrEmpty("\"aftersavefunc\": {0},", editingOptions.AfterSaveFunc)
                .AppendWithLineNonNullOrEmpty("\"errorfunc\": {0},", editingOptions.ErrorFunc)
                .AppendWithLineNonNullOrEmpty("\"afterrestorefunc\": {0},", editingOptions.AfterRestoreFunc)
                .RemoveLast(COMMA);
            return sb.ToString();
        }
    }
}