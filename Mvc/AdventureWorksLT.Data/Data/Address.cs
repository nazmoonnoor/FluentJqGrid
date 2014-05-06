//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorksLT.Data.Data
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public Address()
        {
            this.CustomerAddress = new HashSet<CustomerAddress>();
            this.SalesOrderHeader = new HashSet<SalesOrderHeader>();
            this.SalesOrderHeader1 = new HashSet<SalesOrderHeader>();
        }
    
        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion { get; set; }
        public string PostalCode { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<CustomerAddress> CustomerAddress { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeader1 { get; set; }
    }
}
