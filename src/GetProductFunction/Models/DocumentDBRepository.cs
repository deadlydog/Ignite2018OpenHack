
//namespace Functions.Models
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Configuration;
//    using System.Linq;
//    using System.Linq.Expressions;
//    using System.Threading.Tasks;
//    using Microsoft.Azure.Documents;
//    using Microsoft.Azure.Documents.Client;
//    using Microsoft.Azure.Documents.Linq;
//    using Microsoft.Azure.Storage;
//    using Microsoft.Azure.CosmosDB.Table;
//    using Microsoft.WindowsAzure.Storage;
//    using Microsoft.WindowsAzure.Storage.Table;

//    public static class DocumentDBRepository<T> where T : class
//    {
//        //private static readonly string DatabaseId = ConfigurationManager.AppSettings["database"];
//        //private static readonly string CollectionId = ConfigurationManager.AppSettings["collection"];
//        //private static DocumentClient client;

         

//    //private static string  connectionString = "DefaultEndpointsProtocol=https;AccountName=bfyoc-t15;AccountKey=Zx5dsBNuMtaPg9VYr6zlZlJb7gw5VglXlsbvScg6Adkeu5LdxfwNy1tqDRRJ6gQfUU9jrRJEHfVdGY9b9Fr4kw==;TableEndpoint=https://bfyoc-t15.table.cosmosdb.azure.com:443/;";
//    //private static CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);
//    //    private static CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

//    //public static async Task<T> GetItemAsync(string ratingId)
//    //    {
//    //        try
//    //        {
//    //            CloudTable table = tableClient.GetTableReference("rating");

//    //            TableQuery<CustomerEntity> query = new TableQuery<CustomerEntity>()
//    //                .Where(
//    //                    TableQuery.CombineFilters(
//    //                        TableQuery.GenerateFilterCondition(PartitionKey, QueryComparisons.Equal, "Smith"),
//    //                        TableOperators.And,
//    //                        TableQuery.GenerateFilterCondition(Email, QueryComparisons.Equal, "Ben@contoso.com")
//    //                ));

//    //            await table.ExecuteQuerySegmentedAsync<CustomerEntity>(query, null);
//    //        }
//    //        catch (DocumentClientException e)
//    //        {
//    //            if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
//    //            {
//    //                return null;
//    //            }
//    //            else
//    //            {
//    //                throw;
//    //            }
//    //        }
//    //    }

//    //    public static async Task<IEnumerable<T>> GetItemsAsync(Expression<Func<T, bool>> predicate)
//    //    {
//    //        IDocumentQuery<T> query = client.CreateDocumentQuery<T>(
//    //            UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId),
//    //            new FeedOptions { MaxItemCount = -1, EnableCrossPartitionQuery = true})
//    //            .Where(predicate)
//    //            .AsDocumentQuery();

//    //        List<T> results = new List<T>();
//    //        while (query.HasMoreResults)
//    //        {
//    //            results.AddRange(await query.ExecuteNextAsync<T>());
//    //        }

//    //        return results;
//    //    }

//    //    public static async Task<Document> CreateItemAsync(T item)
//    //    {
//    //        return await client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId), item);
//    //    }

//    //    public static async Task<Document> UpdateItemAsync(string id, T item)
//    //    {
//    //        return await client.ReplaceDocumentAsync(UriFactory.CreateDocumentUri(DatabaseId, CollectionId, id), item);
//    //    }

//    //    public static async Task DeleteItemAsync(string id, string category)
//    //    {
//    //        await client.DeleteDocumentAsync(UriFactory.CreateDocumentUri(DatabaseId, CollectionId, id));
//    //    }

//    //    public static void Initialize()
//    //    {
//    //        client = new DocumentClient(new Uri(ConfigurationManager.AppSettings["endpoint"]), ConfigurationManager.AppSettings["authKey"]);
//    //        CreateDatabaseIfNotExistsAsync().Wait();
//    //        CreateCollectionIfNotExistsAsync().Wait();
//    //    }

//    //    private static async Task CreateDatabaseIfNotExistsAsync()
//    //    {
//    //        try
//    //        {
//    //            await client.ReadDatabaseAsync(UriFactory.CreateDatabaseUri(DatabaseId));
//    //        }
//    //        catch (DocumentClientException e)
//    //        {
//    //            if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
//    //            {
//    //                await client.CreateDatabaseAsync(new Database { Id = DatabaseId });
//    //            }
//    //            else
//    //            {
//    //                throw;
//    //            }
//    //        }
//    //    }

//    //    private static async Task CreateCollectionIfNotExistsAsync()
//    //    {
//    //        try
//    //        {
//    //            await client.ReadDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId));
//    //        }
//    //        catch (DocumentClientException e)
//    //        {
//    //            if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
//    //            {
//    //                await client.CreateDocumentCollectionAsync(
//    //                    UriFactory.CreateDatabaseUri(DatabaseId),
//    //                    new DocumentCollection
//    //                        {
//    //                            Id = CollectionId
//    //                        },
//    //                    new RequestOptions { OfferThroughput = 400 });
//    //            }
//    //            else
//    //            {
//    //                throw;
//    //            }
//    //        }
//    //    }
//    }
//}
