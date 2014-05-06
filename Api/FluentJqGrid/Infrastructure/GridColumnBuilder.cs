using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Web.Mvc;
using FluentJqGrid.Core;
using FluentJqGrid.Core.Edit;
using FluentJqGrid.Core.Form;
using FluentJqGrid.Core.Search;
using FluentJqGrid.Infrastructure.Edit;
using FluentJqGrid.Infrastructure.Form;
using FluentJqGrid.Infrastructure.Search;
using FluentJqGrid.Settings;

namespace FluentJqGrid.Infrastructure
{
    public class GridColumnBuilder<T> : IGridColumnBuilder<T>,IGridColumnBinder<T>, IDisposable
    {
        private IList<GridColumnOptions> _jqGridColumns;
        private readonly HtmlHelper<T> _html;
        private GridColumnOptions _column;

        internal GridColumnBuilder(HtmlHelper<T> html, IList<GridColumnOptions> jqGridColumns)
        {
            _html = html;
            _jqGridColumns = jqGridColumns;
        }

        public IGridColumnBuilder<T> Align(ColumnAlign align)
        {
            _column.Align = align;
            return this;
        }

        public IGridColumnBuilder<T> CellAttribute(string attribute)
        {
            _column.CellAttribute = attribute;
            return this;
        }

        public IGridColumnBuilder<T> Classes(string classes)
        {
            _column.Classes = classes;
            return this;
        }

        public IGridColumnBuilder<T> DateFormat(string dateFormat)
        {
            _column.DateFormat = dateFormat;
            return this;
        }

        public IGridColumnBuilder<T> DefaultValue(string defaultValue)
        {
            _column.DefaultValue = defaultValue;
            return this;
        }

        public IGridColumnBuilder<T> Editable(bool editable)
        {
            _column.Editable = editable;
            return this;
        }

        public IGridColumnBuilder<T> EditOptions(Action<IColumnEdit> columnEditAction)
        {
            var editOptions = new ColumnEditOptions();
            var columnEdit = new ColumnEdit(editOptions);
            columnEditAction(columnEdit);
            _column.EditOptions = editOptions;
            return this;
        }

        public IGridColumnBuilder<T> EditRules(Action<IEditRules> editRules)
        {
            var editRulesOptions = new ColumnEditRules();
            var columnEditRules = new EditRules(editRulesOptions);
            editRules(columnEditRules);
            _column.EditRules = editRulesOptions;
            return this;
        }

        public IGridColumnBuilder<T> FirstSortOrder(string firstSortOrder)
        {
            _column.FirstSortOrder = firstSortOrder;
            return this;
        }

        public IGridColumnBuilder<T> Fixed(bool fixedWidth)
        {
            _column.Fixed = fixedWidth;
            return this;
        }

        public IGridColumnBuilder<T> FormOptions(Action<IColumnForm> formOptionsAction)
        {
            var formOptions = new ColumnFormOptions();
            var columnForm = new ColumnForm(formOptions);
            formOptionsAction(columnForm);
            _column.FormOptions = formOptions;
            return this;
        }

        public IGridColumnBuilder<T> FormatOptions(string formatOptions)
        {
            _column.FormatOptions = formatOptions;
            return this;
        }

        public IGridColumnBuilder<T> Formatter(string formatter)
        {
            _column.Formatter = formatter;
            return this;
        }

        public IGridColumnBuilder<T> Frozen(bool frozen)
        {
            _column.Frozen = frozen;
            return this;
        }

        public IGridColumnBuilder<T> HideInDialog(bool hideInDialog)
        {
            _column.HideInDialog = hideInDialog;
            return this;
        }

        public IGridColumnBuilder<T> Hidden(bool hidden)
        {
            _column.Hidden = hidden;
            return this;
        }

        public IGridColumnBuilder<T> Index(string index)
        {
            _column.Index = index;
            return this;
        }

        public IGridColumnBuilder<T> JsonMap(string jsonMap)
        {
            _column.JsonMap = jsonMap;
            return this;
        }

        public IGridColumnBuilder<T> Key(bool key)
        {
            _column.Key = key;
            return this;
        }

        public IGridColumnBuilder<T> Label(string label)
        {
            _column.Label = label;
            return this;
        }

        public IGridColumnBuilder<T> Resizable(bool resizable)
        {
            _column.Resizable = resizable;
            return this;
        }

        public IGridColumnBuilder<T> Search(bool search)
        {
            _column.Search = search;
            return this;
        }
        
        public IGridColumnBuilder<T> SearchOptions(Action<ISearchOptions> searchOptionsAction)
        {
            var searchOptions = new ColumnSearchOptions();
            var searchBuilder = new SearchOptions(searchOptions);
            searchOptionsAction(searchBuilder);
            _column.SearchOptions = searchOptions;
            return this;
        }

        public IGridColumnBuilder<T> SearchRules(Action<ISearchRules> searchRulesAction)
        {
            var searchRules = new ColumnSearchRules();
            var searchRulesBuilder = new SearchRules(searchRules);
            searchRulesAction(searchRulesBuilder);
            _column.SearchRules = searchRules;
            searchRulesBuilder.Dispose();
            return this;
        }

        public IGridColumnBuilder<T> Sortable(bool sortable)
        {
            _column.Sortable = sortable;
            return this;
        }

        public IGridColumnBuilder<T> SortType(ColumnSortType sortType)
        {
            _column.SortType = sortType;
            return this;
        }

        public IGridColumnBuilder<T> SearchType(string searchType)
        {
            _column.SearchType = searchType;
            return this;
        }

        public IGridColumnBuilder<T> SUrl(string surl)
        {
            _column.SUrl = surl;
            return this;
        }

        public IGridColumnBuilder<T> Template(string template)
        {
            _column.Template = template;
            return this;
        }

        public IGridColumnBuilder<T> TitleOnHover(bool titleOnHover)
        {
            _column.TitleOnHover = titleOnHover;
            return this;
        }

        public IGridColumnBuilder<T> Width(int width)
        {
            _column.Width = width;
            return this;
        }

        public IGridColumnBuilder<T> XmlMap(string xmlMap)
        {
            _column.XmlMap = xmlMap;
            return this;
        }

        public IGridColumnBuilder<T> UnFormat(string unFormat)
        {
            _column.UnFormat = unFormat;
            return this;
        }

        public IGridColumnBuilder<T> Viewable(bool viewable)
        {
            _column.Viewable = viewable;
            return this;
        }

        public IGridColumnBuilder<T> Header(string header)
        {
            _column.Header = header;
            return this;
        }

        public IGridColumnBuilder<T> Bind(string name)
        {
            _column = null;
            _column = new GridColumnOptions
            {
                Name = name,
                Header = name
            };
            _jqGridColumns.Add(_column);
            return this;
        }

        public IGridColumnBuilder<T> Bind<TProperty>(Expression<Func<T, TProperty>> expression)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, _html.ViewData);
            _column = new GridColumnOptions
            {
                Name = (string)GetMetaDataValue(metadata, "Name", metadata.PropertyName),
                Header = (string)GetMetaDataValue(metadata, "Header", metadata.PropertyName),
                Index = (string)GetMetaDataValue(metadata, "Index"),
                Width = (int?)GetMetaDataValue(metadata, "Width"),
                Align = (ColumnAlign?)GetMetaDataValue(metadata, "Align"),
                Editable = (bool?)GetMetaDataValue(metadata, "Editable"),
                Sortable = (bool?)GetMetaDataValue(metadata, "Sortable"),
                EditType = (EditType?)GetMetaDataValue(metadata, "EditType"),
                SortType = (ColumnSortType?)GetMetaDataValue(metadata, "SortType")
            };
            _jqGridColumns.Add(_column);
            return this;
        }

        public void LoadJqGridColumnSettings(IEnumerable<JqGridColumnSettings> jqGridColumnSettiongs)
        {
            jqGridColumnSettiongs.ToList().ForEach(c=>_jqGridColumns.Add(c.ToColumnOption()));
        }

        private object GetMetaDataValue(ModelMetadata metadata, string key, object defaultValue = null)
        {
            return metadata.AdditionalValues.ContainsKey(key) ? metadata.AdditionalValues[key] : defaultValue;
        }

        public void Dispose()
        {
            _jqGridColumns = null;
            _column = null;
            GC.SuppressFinalize(this);
        }
    }
}