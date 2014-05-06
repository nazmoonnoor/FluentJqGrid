using FluentJqGrid.Core.Edit;

namespace FluentJqGrid.Infrastructure.Edit
{
    public class EditRules : IEditRules
    {
        private readonly ColumnEditRules _columnEditRules;

        internal EditRules(ColumnEditRules columnEditRules)
        {
            _columnEditRules = columnEditRules;
        }

        public IEditRules EditHidden(bool editHidden)
        {
            _columnEditRules.EditHidden = editHidden;
            return this;
        }

        public IEditRules Required(bool required)
        {
            _columnEditRules.Required = required;
            return this;
        }

        public IEditRules Number(bool number)
        {
            _columnEditRules.Number = number;
            return this;
        }

        public IEditRules Integer(bool integer)
        {
            _columnEditRules.Integer = integer;
            return this;
        }

        public IEditRules MinValue(int minValue)
        {
            _columnEditRules.MinValue = minValue;
            return this;
        }

        public IEditRules MaxValue(int maxValue)
        {
            _columnEditRules.MaxValue = maxValue;
            return this;
        }

        public IEditRules Email(bool email)
        {
            _columnEditRules.Email = email;
            return this;
        }

        public IEditRules Url(bool url)
        {
            _columnEditRules.Url = url;
            return this;
        }

        public IEditRules Date(bool date)
        {
            _columnEditRules.Date = date;
            return this;
        }

        public IEditRules Time(bool time)
        {
            _columnEditRules.Time = time;
            return this;
        }

        public IEditRules Custom(bool custom)
        {
            _columnEditRules.Custom = custom;
            return this;
        }

        public IEditRules CustomFunction(string customFunction)
        {
            _columnEditRules.CustomFunction = customFunction;
            return this;
        }
    }
}