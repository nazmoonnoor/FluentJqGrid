using System;
using System.Linq.Expressions;
using FluentJqGrid.Settings;

namespace FluentJqGrid.Infrastructure
{
    public interface IGridColumnBinder<T>
    {
        /// <summary>
        /// Sets a JqGrid column element by the specified string name.
        /// </summary>
        /// <param name="name">JqGrid column name</param>
        /// <returns></returns>
        IGridColumnBuilder<T> Bind(string name);

        /// <summary>
        /// Sets a JqGrid column element that represented the properties of the expression.
        /// </summary>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="expression">An expression that identifies the object than contains the properties to render</param>
        /// <returns></returns>
        IGridColumnBuilder<T> Bind<TProperty>(Expression<Func<T, TProperty>> expression);

        /// <summary>
        /// Sets a JqGrid column list elements by the JqGridColumnSettiongs array.
        /// </summary>
        /// <param name="jqGridColumnSettiongs"></param>
        void LoadJqGridColumnSettings(System.Collections.Generic.IEnumerable<JqGridColumnSettings> jqGridColumnSettiongs);
    }
}