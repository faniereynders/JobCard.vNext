using AzureFromTheTrenches.Commanding.Abstractions;
using JobcardCloud.CustomerManagement.Models;

namespace JobcardCloud.CustomerManagement.Commands
{
    public class CreatePersonCustomerCommand : NewCustomerCommand, ICommand<CustomerModel>
    {
        public string PersonIdNumber { get => base.CustomerId; set => base.CustomerId = value; }
    }
}