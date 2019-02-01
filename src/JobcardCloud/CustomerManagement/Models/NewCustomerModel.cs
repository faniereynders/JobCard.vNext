using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobcardCloud.CustomerManagement.Models
{
    public class NewCustomerModel
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Id { get; set; }
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
}