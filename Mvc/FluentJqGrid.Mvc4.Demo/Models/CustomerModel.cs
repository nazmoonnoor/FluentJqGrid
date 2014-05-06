namespace FluentJqGrid.Mvc4.Demo.Models
{
    public class CustomerModel
    {
        public int CustomerID { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }

    public class CustomerGridModel
    {
        public int CustomerID { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}