using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using Microsoft.WindowsAzure.Storage;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http.Extensions;

namespace JobcardCloud.Customers
{
    public class CustomerEntity:TableEntity
    {
        public string Type { get; set; }
        public string Id { get; set; }
    }

    public class NewCustomerModel
    {
        public string Type { get; set; }
        public string Id { get; set; }
    }

    public class CustomerModel
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string TenantId { get; set; }
        public string Type { get; set; }
    }
    public static class Customers
    {
        private static Uri GetUri(HttpRequest request)
        {
            var builder = new UriBuilder();
            builder.Scheme = request.Scheme;
            builder.Host = request.Host.Value;
            builder.Path = request.Path;
            builder.Query = request.QueryString.ToUriComponent();
            return builder.Uri;
        }
        private const string route = "customers";

        [FunctionName(nameof(CreateCustomer))]
        public static async Task<IActionResult> CreateCustomer(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = route)]HttpRequest req,
            [Table("customers")] IAsyncCollector<CustomerEntity> customersTable,
            [Table("customers")] CloudTable customersCloudTable,
            IBinder binder,
            ILogger log)
        {
            var tenantId = req.Headers["X-TenantId"];

            

            log.LogInformation("Creating a new customer item");
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var input = JsonConvert.DeserializeObject<NewCustomerModel>(requestBody);

            
            var query = new TableQuery<CustomerEntity>();
            var customersWithIdCount = query.Where(TableQuery.CombineFilters(
                    TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal,
                        tenantId),
                    TableOperators.And,
                    TableQuery.GenerateFilterCondition("Id", QueryComparisons.Equal,
                        input.Id)))
                 .TakeCount;

            var count = await customersCloudTable.ExecuteQuerySegmentedAsync(query, null);

            
            if (count.Any())
            {
                return new BadRequestObjectResult(new { error = "Customer already exists." });
            }

            var newCustomer = new CustomerEntity() { PartitionKey = tenantId, RowKey = Guid.NewGuid().ToString(), Type = input.Type,Id = input.Id };
            await customersTable.AddAsync(newCustomer);
            var result = new CustomerModel
            {
                Id = newCustomer.RowKey,
                CustomerId = newCustomer.Id,
                TenantId = newCustomer.PartitionKey,
                Type = newCustomer.Type
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

        [FunctionName(nameof(GetCustomerById))]
        public static async Task<IActionResult> GetCustomerById(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = route + "/{id}")]HttpRequest req,
            IBinder binder,
            ILogger log, string id)
        {
            if (!req.Headers.ContainsKey("X-TenantId"))
            {
                return new BadRequestObjectResult(new { error = "Tenant is required." });
            }
            var tenantId = req.Headers["X-TenantId"];
            

            TableAttribute dynamicTableBinding = new TableAttribute("customers", tenantId, "{id}");
            var customer = await binder.BindAsync<CustomerEntity>(dynamicTableBinding);
            log.LogInformation("Getting customer item by id");
            if (customer == null)
            {
                log.LogInformation($"Customer {id} not found");
                return new NotFoundResult();
            }
            var result = new CustomerModel
            {
                Id = customer.RowKey,
                TenantId = customer.PartitionKey,
                Type = customer.Type
            };
            return new OkObjectResult(result);
        }

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