using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http.Extensions;
using JobcardCloud.CustomerManagement.Entities;
using JobcardCloud.CustomerManagement.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;
using JobcardCloud.Customers.Mappings;

namespace JobcardCloud.CustomerManagement.Functions
{
    public static class CreateCustomer
    {
        static CreateCustomer()
        {
            AutoMapper.Mapper.Initialize(c => c.AddProfile<CustomerProfile>());
        }
        
        [FunctionName(nameof(CreateCustomer))]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "customers")]HttpRequest req,
            [Table("customers")] IAsyncCollector<CustomerEntity> customersTable,
            [Table("customers")] CloudTable customersCloudTable,
            IBinder binder,
           // [Inject]IMapper mapper,
            ILogger log)
        {
            var tenantId = req.Headers["X-TenantId"];
            //TODO: validate if tenant exists


            


            log.LogInformation("Creating a new customer item");

            

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var results = new List<ValidationResult>();
            var isValid = true;

            //TODO Use smarter serialization
            var input = JsonConvert.DeserializeObject<NewCustomerModelBase>(requestBody);
            if (input.Type == "Person")
            {
                input = JsonConvert.DeserializeObject<NewPersonCustomerModel>(requestBody);
                isValid = Validator.TryValidateObject(input, new ValidationContext(input, null, null), results, true);
            }
            else
            {
                input = JsonConvert.DeserializeObject<NewCompanyCustomerModel>(requestBody);
                isValid = Validator.TryValidateObject(input, new ValidationContext(input, null, null), results, true);
            }


            if (!isValid)
            {
                return new BadRequestObjectResult(results);
            }




            //TODO: Move to validator later - IValidatableObject
            var query = new TableQuery<CustomerEntity>();
            var customersWithIdCount = query.Where(TableQuery.CombineFilters(
                    TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal,
                        tenantId),
                    TableOperators.And,
                    TableQuery.GenerateFilterCondition("CustomerId", QueryComparisons.Equal,
                        input.CustomerId)))
                 .TakeCount;

            var count = await customersCloudTable.ExecuteQuerySegmentedAsync(query, null);

            //TODO: Check if customer already exists
            if (count.Any())
            {
                return new BadRequestObjectResult(new { error = "Customer already exists." });
            }

            input.TenantId = tenantId;


            
            var newCustomerEntity = default(CustomerEntity);
            if (input.Type == "Person")
            {
                newCustomerEntity = Mapper.Map<PersonCustomerEntity>(input);
            }
            else if (input.Type == "Company")
            {
                newCustomerEntity = Mapper.Map<CompanyCustomerEntity>(input);
            }



            //TODO: Move to repo
            await customersTable.AddAsync(newCustomerEntity);
            var result = new CustomerModel
            {
                Id = newCustomerEntity.RowKey,
                CustomerId = input.CustomerId,
                TenantId = newCustomerEntity.PartitionKey,
                Type = input.Type
            };
            return new CreatedResult($"{req.GetDisplayUrl()}/{result.Id}", result);
        }

        //[FunctionName("Table_GetTodos")]
        //public static async Task<IActionResult> GetTodos(
        //    [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = route)]HttpRequest req,
        //    // unfortunately IQueryable<TodoTableEntity> binding not supported in functions v2
        //    [Table("todos", Connection = "AzureWebJobsStorage")] CloudTable todoTable,
        //    TraceWriter log)
        //{
        //    log.Info("Getting todo list items");
        //    var query = new TableQuery<TodoTableEntity>();
        //    var segment = await todoTable.ExecuteQuerySegmentedAsync(query, null);
        //    return new OkObjectResult(segment.Select(Mappings.ToTodo));
        //}

       

        //[FunctionName("Table_UpdateTodo")]
        //public static async Task<IActionResult> UpdateTodo(
        //    [HttpTrigger(AuthorizationLevel.Anonymous, "put", Route = route + "/{id}")]HttpRequest req,
        //    [Table("todos", Connection = "AzureWebJobsStorage")] CloudTable todoTable,
        //    TraceWriter log, string id)
        //{

        //    string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        //    var updated = JsonConvert.DeserializeObject<TodoUpdateModel>(requestBody);
        //    var findOperation = TableOperation.Retrieve<TodoTableEntity>("TODO", id);
        //    var findResult = await todoTable.ExecuteAsync(findOperation);
        //    if (findResult.Result == null)
        //    {
        //        return new NotFoundResult();
        //    }
        //    var existingRow = (TodoTableEntity)findResult.Result;

        //    existingRow.IsCompleted = updated.IsCompleted;
        //    if (!string.IsNullOrEmpty(updated.TaskDescription))
        //    {
        //        existingRow.TaskDescription = updated.TaskDescription;
        //    }

        //    var replaceOperation = TableOperation.Replace(existingRow);
        //    await todoTable.ExecuteAsync(replaceOperation);

        //    return new OkObjectResult(existingRow.ToTodo());
        //}

        //[FunctionName("Table_DeleteTodo")]
        //public static async Task<IActionResult> DeleteTodo(
        //    [HttpTrigger(AuthorizationLevel.Anonymous, "delete", Route = route + "/{id}")]HttpRequest req,
        //    [Table("todos", Connection = "AzureWebJobsStorage")] CloudTable todoTable,
        //    TraceWriter log, string id)
        //{
        //    var deleteOperation = TableOperation.Delete(new TableEntity() { PartitionKey = "TODO", RowKey = id, ETag = "*" });
        //    try
        //    {
        //        var deleteResult = await todoTable.ExecuteAsync(deleteOperation);
        //    }
        //    catch (StorageException e) when (e.RequestInformation.HttpStatusCode == 404)
        //    {
        //        return new NotFoundResult();
        //    }
        //    return new OkResult();
        //}
    }
}