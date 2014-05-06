using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentJqGrid.Core;
using FluentJqGrid.Infrastructure;
using FluentJqGrid.ToScript.Form;

namespace FluentJqGrid.ToScript
{
	internal class FormEditingToScript : ToScriptBase, IToScript
	{
		private readonly string _gridName;
		private readonly FormEditingOptions _formEditingOptions;

		internal FormEditingToScript(string gridName, FormEditingOptions formEditingOptions)
		{
			_gridName = gridName;
			_formEditingOptions = formEditingOptions;
		}

		public string ToScript()
		{
			if (_formEditingOptions == null) return string.Empty;
			var sb = new StringBuilder();

			if (_formEditingOptions.EditGridRow !=null)
				sb.AppendFormat("$(\"#{0}\").click(function(){{" +
					"{1}var gr = $(\"#{2}\").jqGrid('getGridParam','selrow');" +
					"{1}if( gr != null ) $(\"#{2}\").jqGrid('editGridRow', gr, {3});" +
					"{1}else alert('Please Select Row');" +
					"{4}}});",
					_formEditingOptions.EditGridRowButtonId,
					NewLine(6),
					_gridName,
					new FormEditToScript(_formEditingOptions.EditGridRow).ToScript(),
					NewLine(0)).AppendLine();

			if (_formEditingOptions.AddGridRow != null)
				sb.AppendFormat("$(\"#{0}\").click(function(){{" +
					"{1}$(\"#{2}\").jqGrid('editGridRow','new', {3});" +
					"{4}}});",
					_formEditingOptions.AddGridRowButtonId,
					NewLine(6),
					_gridName,
					new FormEditToScript(_formEditingOptions.AddGridRow).ToScript(),
					NewLine(0)).AppendLine();

			if (_formEditingOptions.DeleteGridRow != null)
				sb.AppendFormat("$(\"#{0}\").click(function(){{" +
					"{1}var gr = $(\"#{2}\").jqGrid('getGridParam','selrow');" +
					"{1}if( gr != null ) $(\"#{2}\").jqGrid('delGridRow', gr, {3});" +
					"{1}else alert('Please Select Row to delete!');" +
					"{4}}});",
					_formEditingOptions.DeleteGridRowButtonId,
					NewLine(6),
					_gridName,
					new FormDeleteToScript(_formEditingOptions.DeleteGridRow).ToScript(),
					NewLine(0)).AppendLine();

			if (_formEditingOptions.ViewGridRow != null)
				sb.AppendFormat("$(\"#{0}\").click(function(){{" +
					"{1}var gr = $(\"#{2}\").jqGrid('getGridParam','selrow');" +
					"{1}if( gr != null ) $(\"#{2}\").jqGrid('viewGridRow', gr, {3});" +
					"{1}else alert('Please Select Row to view!');" +
					"{4}}});",
					_formEditingOptions.ViewGridRowButtonId,
					NewLine(6),
					_gridName,
					new FormViewToScript(_formEditingOptions.ViewGridRow).ToScript(),
					NewLine(0)).AppendLine();

			return sb.ToString();
		}
	}
}
