using System.Collections.Generic;
using System.Text;
using FluentJqGrid.Core.Edit;
using FluentJqGrid.Extensions;
using FluentJqGrid.Infrastructure;

namespace FluentJqGrid.ToScript.Edit
{
    internal class ColumnEditToScript : ToScriptBase, IToScript
    {
        private readonly ColumnEditOptions _columnEditOptions;

        internal ColumnEditToScript(ColumnEditOptions columnEditOptions)
        {
            _columnEditOptions = columnEditOptions;
        }

        public string ToScript()
        {
            return GetEditOptions(_columnEditOptions);
        }

        private string GetEditOptions(ColumnEditOptions columnEditOptions)
        {
            if (columnEditOptions == null) return string.Empty;
            var sb = new StringBuilder();
            switch (columnEditOptions.EditType)
            {
                case EditType.Button:
                    ToButtonOption(ref sb, columnEditOptions);
                    break;
                case EditType.Check:
                    ToCheckOption(ref sb, columnEditOptions);
                    break;
                case EditType.Custom:
                    ToCustomOption(ref sb, columnEditOptions);
                    break;
                case EditType.File:
                    ToFileOption(ref sb, columnEditOptions);
                    break;
                case EditType.Image:
                    ToImageOption(ref sb, columnEditOptions);
                    break;
                case EditType.Select:
                    ToSelectOption(ref sb, columnEditOptions);
                    break;
                case EditType.Text:
                    ToTextOption(ref sb, columnEditOptions);
                    break;
                case EditType.Password:
                    ToPasswordOption(ref sb, columnEditOptions);
                    break;
                case EditType.TextArea:
                    ToTextareaOption(ref sb, columnEditOptions);
                    break;
            }
            return sb.ToString();
        }

        private void ToButtonOption(ref StringBuilder sb, ColumnEditOptions columnEditOptions)
        {
            string value = columnEditOptions.Value.ToString();
            var buttonOptions = new StringBuilder();
            buttonOptions.AppendNonNullOrEmpty("value: {0}, ", Asq(value));
            AddCommonAttr(columnEditOptions, ref buttonOptions);
            buttonOptions.RemoveLast(COMMA);
            sb.AppendNonNullOrEmpty("edittype:'button', editoptions: {{{0}}}, ", buttonOptions);
        }

        private void ToCheckOption(ref StringBuilder sb, ColumnEditOptions columnEditOptions)
        {
            string value = (columnEditOptions.Value != null && (bool)columnEditOptions.Value != false)
                               ? "Yes:No"
                               : string.Empty;
            var checkOptions = new StringBuilder();
            checkOptions.AppendNonNullOrEmpty("value: {0}, ", value);
            AddCommonAttr(columnEditOptions, ref checkOptions);
            checkOptions.RemoveLast(COMMA);
            sb.AppendNonNullOrEmpty("edittype:'checkbox', editoptions: {{{0}}}, ", checkOptions);
        }

        private void ToCustomOption(ref StringBuilder sb, ColumnEditOptions columnEditOptions)
        {
            throw new System.NotImplementedException();
        }

        private void ToFileOption(ref StringBuilder sb, ColumnEditOptions columnEditOptions)
        {
            throw new System.NotImplementedException();
        }

        private void ToImageOption(ref StringBuilder sb, ColumnEditOptions columnEditOptions)
        {
            var imageOptions = new StringBuilder();
            imageOptions.AppendNonNullOrEmpty("src: {0}, ", columnEditOptions.ImageSrc);
            AddCommonAttr(columnEditOptions, ref imageOptions);
            imageOptions.RemoveLast(COMMA);
            sb.AppendNonNullOrEmpty("edittype:'image', editoptions: {{{0}}}, ", imageOptions);
        }

        private void ToSelectOption(ref StringBuilder sb, ColumnEditOptions columnEditOptions)
        {
            var selectOptions = new StringBuilder();
            string selectValues = GetSelectValues(columnEditOptions);
            selectOptions.AppendNonNullOrEmpty("dataUrl: {0}, ", Asq(columnEditOptions.DataUrl));
            selectOptions.AppendNonNullOrEmpty("buildSelect: {0}, ", columnEditOptions.BuildSelect);
            selectOptions.AppendNonNullOrEmpty("value: {0}, ", selectValues);
            AddCommonAttr(columnEditOptions, ref selectOptions);
            selectOptions.RemoveLast(COMMA);
            sb.AppendNonNullOrEmpty("edittype:'select', editoptions: {{{0}}}, ", selectOptions);
        }

        private void ToTextOption(ref StringBuilder sb, ColumnEditOptions columnEditOptions)
        {
            var textOptions = new StringBuilder();
            textOptions.AppendNonNullOrEmpty("size: {0}, ", columnEditOptions.Size);
            textOptions.AppendNonNullOrEmpty("maxlength: {0}, ", columnEditOptions.MaxLength);
            textOptions.AppendNonNullOrEmpty("readonly: {0}, ", ToLowerString(columnEditOptions.ReadOnly));
            AddCommonAttr(columnEditOptions, ref textOptions);
            textOptions.RemoveLast(COMMA);
            string result = textOptions.ToString();
            sb.AppendNonNullOrEmpty("edittype:'text', editoptions: {{{0}}}, ", textOptions);
        }

        private void ToPasswordOption(ref StringBuilder sb, ColumnEditOptions columnEditOptions)
        {
            var passwordOptions = new StringBuilder();
            passwordOptions.AppendNonNullOrEmpty("size: {0}, ", columnEditOptions.Size);
            passwordOptions.AppendNonNullOrEmpty("maxlength: {0}, ", columnEditOptions.MaxLength);
            passwordOptions.AppendNonNullOrEmpty("readonly: {0}, ", ToLowerString(columnEditOptions.ReadOnly));
            AddCommonAttr(columnEditOptions, ref passwordOptions);
            passwordOptions.RemoveLast(COMMA);
            sb.AppendNonNullOrEmpty("edittype:'password', editoptions: {{{0}}}, ", passwordOptions);
        }

        private void ToTextareaOption(ref StringBuilder sb, ColumnEditOptions columnEditOptions)
        {
            int rows = columnEditOptions.Rows ?? 2;
            int cols = columnEditOptions.Cols ?? 20;
            var textOptions = new StringBuilder();
            textOptions.AppendNonNullOrEmpty("rows: {0}, cols: {1}, ", rows, cols, 0);
            AddCommonAttr(columnEditOptions, ref textOptions);
            textOptions.RemoveLast(COMMA);
            sb.AppendNonNullOrEmpty("edittype:'textarea', editoptions: {{{0}}}, ", textOptions);
        }

        private string SetAttribute(string att, string value)
        {
            string str = string.Empty;
            if (value != null)
                str = string.Format("{0}: {1} ", att, value);
            return str;
        }

        private string GetSelectValues(ColumnEditOptions columnEditOptions)
        {
            var selectValues = columnEditOptions.Value as Dictionary<string, string>;
            if (selectValues != null)
            {
                var sbv = new StringBuilder();
                sbv.Append("{");
                foreach (var value in selectValues)
                {
                    sbv.AppendFormat("{0}: {1}, ", value.Key, Asq(value.Value));
                }
                sbv = sbv.Remove(sbv.ToString().LastIndexOf(','), 1);
                sbv.Append("}");
                return sbv.ToString();
            }
            return "{}";
        }

        private void AddCommonAttr(ColumnEditOptions columnEditOptions, ref StringBuilder options)
        {
            options.AppendNonNullOrEmpty("{0}, ", columnEditOptions.DataInit);
            options.AppendNonNullOrEmpty("{0}, ", columnEditOptions.DataEvents);
            options.AppendNonNullOrEmpty("{0}, ", columnEditOptions.DefaultValue);
            options.AppendNonNullOrEmpty("{0}, ", ToLowerString(columnEditOptions.NullIfEmpty));
            options.AppendNonNullOrEmpty("{0}, ", columnEditOptions.Attributes);
        }

    }
}