using System.Web;
using System.Web.Mvc;
using FluentJqGrid.Infrastructure;

namespace FluentJqGrid
{
    public static class JqGridHelper
    {
        public static GridBuilder<T> JqGrid<T>(this HtmlHelper<T> html) where T : class
        {
            return new GridBuilder<T>(html);
        }

        public static GridBuilder<T> JqGrid<T>(this HtmlHelper<T> html, T dataSource) where T : class
        {
            return new GridBuilder<T>(html);
        }
    }

}