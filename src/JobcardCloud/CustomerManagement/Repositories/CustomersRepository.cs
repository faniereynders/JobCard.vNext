using System;
using System.Threading.Tasks;
using JobcardCloud.CustomerManagement.Entities;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

public class DocumentDBRepository<T> where T : EntityBase
{

    private static readonly string Endpoint = "https://localhost:8081";
    private static readonly string Key = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
    private static readonly string DatabaseId = "CustomerManagement";
    private static readonly string CollectionId = "Customers";
    private static DocumentClient client;

    public async Task<T> GetItemAsync(string id, string partitionKey)
    {
        try
        {
            var options = new RequestOptions{PartitionKey = new PartitionKey(partitionKey)};
            var document = await client.ReadDocumentAsync(UriFactory.CreateDocumentUri(DatabaseId, CollectionId, id), options);
            return (T)(dynamic)document;
        }
        catch (DocumentClientException e)
        {
            if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
            else
            {
                throw;
            }
        }
    }


    public async Task<Document> CreateItemAsync(T item)
    {
        var options = new RequestOptions{PartitionKey = new PartitionKey(item.TenantId)};
        return await client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId), item, options);
    }


    public DocumentDBRepository()
    {
        client = new DocumentClient(new Uri(Endpoint), Key);
        CreateDatabaseIfNotExistsAsync().Wait();
        CreateCollectionIfNotExistsAsync().Wait();
    }

    private static async Task CreateDatabaseIfNotExistsAsync()
    {
        try
        {
            await client.ReadDatabaseAsync(UriFactory.CreateDatabaseUri(DatabaseId));
        }
        catch (DocumentClientException e)
        {
            if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                await client.CreateDatabaseAsync(new Database { Id = DatabaseId });
            }
            else
            {
                throw;
            }
        }
    }

    private static async Task CreateCollectionIfNotExistsAsync()
    {
        try
        {
            await client.ReadDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId));
        }
        catch (DocumentClientException e)
        {
            if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                await client.CreateDocumentCollectionAsync(
                    UriFactory.CreateDatabaseUri(DatabaseId),
                    new DocumentCollection { Id = CollectionId },
                    new RequestOptions { OfferThroughput = 1000 });
            }
            else
            {
                throw;
            }
        }
    }
}