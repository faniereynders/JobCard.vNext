using Microsoft.WindowsAzure.Storage.Table;

namespace JobcardCloud.CustomerManagement.Entities
{
    public class EntityBase
    {
        public string TenantId { get; set; } 
    }
    public class CustomerEntity:EntityBase
    {
        public string Type { get; set; }
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string PostalAddress { get; set; }
        public string ResidentialAddress { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

    }
    public class PersonCustomerEntity : CustomerEntity { }
    public class CompanyCustomerEntity : CustomerEntity
    {
        public string VATRegistrationNumber { get; set; }
        public string Director1_Name { get; set; }
        public string Director1_IDNumber { get; set; }
        public string Director2_Name { get; set; }
        public string Director2_IDNumber { get; set; }
        public string Director3_Name { get; set; }
        public string Director3_IDNumber { get; set; }
        public string Director4_Name { get; set; }
        public string Director4_IDNumber { get; set; }

        public string ManagerName { get; set; }
    }
}