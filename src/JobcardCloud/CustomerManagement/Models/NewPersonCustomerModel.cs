using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace JobcardCloud.CustomerManagement.Models
{
    public class NewCustomerModelBase
    {
        public string TenantId { get; set; }
        [Required]
        public string Type { get; set; }

        [JsonIgnore]
        public string CustomerId { get; set; }
    }
    public class NewCustomerModel : NewCustomerModelBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public string PostalAddress { get; set; }
        [Required]
        public string ResidentialAddress { get; set; }
        [Required]
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        [EmailAddress]
        public string Email { get; set; }


    }

    public class NewPersonCustomerModel : NewCustomerModel
    {
        [Required]
        public string PersonIdNumber { get => base.CustomerId; set => base.CustomerId = value; }
    }
    public class NewCompanyCustomerModel : NewCustomerModel
    {
        [Required]
        public string CompanyRegistrationNumber { get => base.CustomerId; set => base.CustomerId = value; }
        public string VATRegistrationNumber { get; set; }
        [Required]
        public string Director1_Name { get; set; }
        [Required]
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