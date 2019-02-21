using System.ComponentModel.DataAnnotations;

public class NewCustomerCommand
{
    public string TenantId { get; set; }
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