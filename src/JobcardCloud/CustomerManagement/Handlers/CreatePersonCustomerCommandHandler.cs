using System.Linq;
using System.Threading.Tasks;
using AzureFromTheTrenches.Commanding.Abstractions;
using JobcardCloud.CustomerManagement.Commands;
using JobcardCloud.CustomerManagement.Entities;
using JobcardCloud.CustomerManagement.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage.Table;

namespace JobcardCloud.CustomerManagement.Handlers
{
    internal class CreatePersonCustomerCommandHandler : ICommandHandler<CreatePersonCustomerCommand, CustomerModel>
    {
        // private readonly ILogger logger;

        // public CreatePersonCustomerCommandHandler(ILogger logger)
        // {
        //     this.logger = logger;
        // }
        public Task<CustomerModel> ExecuteAsync(CreatePersonCustomerCommand command, CustomerModel previousResult)
        {
            
          //   logger.LogInformation("Creating a new customer item");

            

//             string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
//             var results = new List<ValidationResult>();
//             var isValid = true;

//             //TODO Use smarter serialization
//             var input = JsonConvert.DeserializeObject<NewCustomerModelBase>(requestBody);
//             if (input.Type == "Person")
//             {
//                 input = JsonConvert.DeserializeObject<NewPersonCustomerModel>(requestBody);
//                 isValid = Validator.TryValidateObject(input, new ValidationContext(input, null, null), results, true);
//             }
//             else
//             {
//                 input = JsonConvert.DeserializeObject<NewCompanyCustomerModel>(requestBody);
//                 isValid = Validator.TryValidateObject(input, new ValidationContext(input, null, null), results, true);
//             }


//             if (!isValid)
//             {
//                 return new BadRequestObjectResult(results);
//             }




//             //TODO: Move to validator later - IValidatableObject


//             input.TenantId = tenantId;


            
//             var newCustomerEntity = default(CustomerEntity);
//             if (input.Type == "Person")
//             {
//                 newCustomerEntity = mapper.Map<PersonCustomerEntity>(input);
//             }
//             else if (input.Type == "Company")
//             {
//                 newCustomerEntity = mapper.Map<CompanyCustomerEntity>(input);
//             }



//             //TODO: Move to repo
//             await customersTable.AddAsync(newCustomerEntity);
//             var result = new CustomerModel
//             {
//                 Id = newCustomerEntity.RowKey,
//                 CustomerId = input.CustomerId,
//                 TenantId = newCustomerEntity.PartitionKey,
//                 Type = input.Type
//             };
//             return new CreatedResult($"{req.GetDisplayUrl()}/{result.Id}", result);
            var model = new CustomerModel();
            return Task.FromResult(model);
        }
    }
}