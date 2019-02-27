using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using JobcardCloud.CustomerManagement.Commands;
using JobcardCloud.CustomerManagement.Entities;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace JobcardCloud.CustomerManagement.Validators
{
    internal class NewCustomerCommandValidator<T> : AbstractValidator<T> where T: NewCustomerCommand
    {
                
        private readonly ILogger logger;
        private readonly CloudTableClient tableClient;

        public NewCustomerCommandValidator(CloudTableClient tableClient)
        {
            //this.binder = binder;
           // this.logger = logger;

            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.AccountNumber).NotEmpty();
            RuleFor(x => x.PostalAddress).NotEmpty();
            RuleFor(x => x.ResidentialAddress).NotEmpty();
            RuleFor(x => x.Telephone1).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();
    //         RuleFor(x=>x).CustomAsync((customer,context,c)=>
    //         {
                
    //           // CloudStorageAccount storageAccount = CloudStorageAccount.Parse("UseDevelopmentStorage=true");

    // // tableClient = storageAccount.CreateCloudTableClient();

    // var customersCloudTable = tableClient.GetTableReference("customers");





             

    //             // var query = new TableQuery<CustomerEntity>();
    //             // var customersWithIdCount = query.Where(TableQuery.CombineFilters(
    //             //         TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal,
    //             //             customer.TenantId),
    //             //         TableOperators.And,
    //             //         TableQuery.GenerateFilterCondition("CustomerId", QueryComparisons.Equal,
    //             //             customer.CustomerId)))
    //             //     .TakeCount;

    //           //var count = await customersCloudTable.ExecuteQuerySegmentedAsync(query, null);

    // //             //TODO: Check if customer already exists
    //           //  if (count.Any())
    //             {
    //          //       context.AddFailure("Customer already exists");
    //             }
    //            // return new Vali

    //            //Task.CompletedTask;
    //         });
            this.tableClient = tableClient;
        }
    }
}