using System;
using FluentJqGrid.Core.Search;

namespace FluentJqGrid.Infrastructure.Search
{
    public class SearchRules : ISearchRules, IDisposable
    {
        private readonly ColumnSearchRules _columnSearchRules;

        internal SearchRules(ColumnSearchRules columnSearchRules)
        {
            _columnSearchRules = columnSearchRules;
        }

        public ISearchRules Required(bool required)
        {
            _columnSearchRules.Required = required;
            return this;
        }

        public ISearchRules Number(bool number)
        {
            _columnSearchRules.Number = number;
            return this;
        }

        public ISearchRules Integer(bool integer)
        {
            _columnSearchRules.Integer = integer;
            return this;
        }

        public ISearchRules MinValue(int minValue)
        {
            _columnSearchRules.MinValue = minValue;
            return this;
        }

        public ISearchRules MaxValue(int maxValue)
        {
            _columnSearchRules.MaxValue = maxValue;
            return this;
        }

        public ISearchRules Email(bool email)
        {
            _columnSearchRules.Email = email;
            return this;
        }

        public ISearchRules Url(bool url)
        {
            _columnSearchRules.Url = url;
            return this;
        }

        public ISearchRules Date(bool date)
        {
            _columnSearchRules.Date = date;
            return this;
        }

        public ISearchRules Time(bool time)
        {
            _columnSearchRules.Time = time;
            return this;
        }

        public ISearchRules Custom(bool custom)
        {
            _columnSearchRules.Custom = custom;
            return this;
        }

        public ISearchRules CustomFunc(string customFunc)
        {
            _columnSearchRules.CustomFunc = customFunc;
            return this;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}