using Microsoft.WindowsAzure.Storage.Table;

namespace JobcardCloud.CustomerManagement.Entities
{
    public class CustomerEntity:TableEntity
    {
        public string Type { get; set; }
        public string Id { get; set; }
    }
}