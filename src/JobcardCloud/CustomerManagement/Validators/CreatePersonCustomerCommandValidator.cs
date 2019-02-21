using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using JobcardCloud.CustomerManagement.Commands;
using Microsoft.Azure.WebJobs;
using Microsoft.WindowsAzure.Storage.Table;

namespace JobcardCloud.CustomerManagement.Validators
{
    internal class CreatePersonCustomerCommandValidator : NewCustomerCommandValidator<CreatePersonCustomerCommand>
    {
        public CreatePersonCustomerCommandValidator(CloudTableClient tableClient):base(tableClient)
        {
            RuleFor(x => x.PersonIdNumber).NotEmpty();
        }

    }
}