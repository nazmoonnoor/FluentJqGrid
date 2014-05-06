using System.Collections.Generic;
using System.ComponentModel;
using AdventureWorksLT.Data.Data;
using FluentJqGrid.Attributes;

namespace FluentJqGrid.Mvc4.Demo.Models
{
    public class CustomerViewModel
    {
        public int CustomerID { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }

        [JqGridColumn(Header = "First Name", Name = "FirstName")]
        [JqGridColumnEdit(Editable2 = "1234567")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string CompanyName { get; set; }
        public string SalesPerson { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<CustomerAddress> CustomerAddress { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
    }
}