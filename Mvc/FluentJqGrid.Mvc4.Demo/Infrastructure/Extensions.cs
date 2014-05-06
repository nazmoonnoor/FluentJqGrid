using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AdventureWorksLT.Data.Infrastructure;

namespace FluentJqGrid.Mvc4.Demo.Infrastructure
{
    public static class Extensions
    {
        public static GridData ToJqGridData<T>(this PagedList<T> keySelector, int page, List<GridRow> gridRows )
        {
            return new GridData
            {
                Page = page,
                Records = keySelector.TotalCount,
                Total = keySelector.TotalPages - 1,
                Rows = gridRows
            };
        }

        public static GridData ToJqGridData<T>(this IQueryable<T> selector, int page, int numberOfRows, List<GridRow> gridRows)
        {
            int totalCount = selector.Count();
            int totalPages = totalCount / numberOfRows;
            return new GridData
            {
                Page = page,
                Records = totalCount,
                Total = totalPages,
                Rows = gridRows.ToList()
            };
        }

        public static TimeSpan Measure(Action action)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            return stopwatch.Elapsed;
        }
    }
}