// using JobcardCloud.CustomerManagement.Entities;
// using JobcardCloud.CustomerManagement.Models;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Azure.WebJobs;
// using Microsoft.Azure.WebJobs.Extensions.Http;
// using Microsoft.Extensions.Logging;
// using System.Threading.Tasks;

// namespace JobcardCloud.Customers.Functions
// {
//     public class GetSingleCustomer
//     {
//         [FunctionName(nameof(GetSingleCustomer))]
//         public async Task<IActionResult> GetCustomerById(
//            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "customers/{id}")]HttpRequest req,
//            IBinder binder,
//            ILogger log, string id)
//         {
//             if (!req.Headers.ContainsKey("X-TenantId"))
//             {
//                 return new BadRequestObjectResult(new { error = "Tenant is required." });
//             }
//             var tenantId = req.Headers["X-TenantId"];


//             TableAttribute dynamicTableBinding = new TableAttribute("customers", tenantId, "{id}");
//             var customer = await binder.BindAsync<CustomerEntity>(dynamicTableBinding);
//             log.LogInformation("Getting customer item by id");
//             if (customer == null)
//             {
//                 log.LogInformation($"Customer {id} not found");
//                 return new NotFoundResult();
//             }

//             //TODO: automapper
//             var result = new CustomerModel
//             {
//                 Id = customer.RowKey,
//                 TenantId = customer.PartitionKey,
//                 Type = customer.Type
//             };
//             return new OkObjectResult(result);
//         }
//     }
// }
