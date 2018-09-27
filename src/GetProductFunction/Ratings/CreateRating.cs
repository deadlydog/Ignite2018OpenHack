using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Functions.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace Functions.Ratings
{
    public static class CreateRating
    {

        [FunctionName("CreateRating")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)]HttpRequestMessage req,
            [CosmosDB(
                databaseName: "FruitIcecream",
                collectionName: "Ratings",
                ConnectionStringSetting = "CosmosDBConnection")] IAsyncCollector<Rating> document, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            try
            {
                var rating = new Rating();
                // Get request body
                dynamic data = await req.Content.ReadAsAsync<object>();
                rating.Id = Guid.NewGuid();
                rating.UserId = data?.userId;
                rating.ProductId = data?.productId;
                rating.Timestamp = DateTime.Now;
                rating.LocationName = data?.locationName;
                rating.RatingValue = data?.rating;
                rating.UserNotes = data?.userNotes;

                await document.AddAsync(rating);
                return req.CreateResponse(HttpStatusCode.OK, "Hello there " );
            }
            catch (Exception ex )
            {
               return  req.CreateResponse(HttpStatusCode.BadRequest, "Please pass a name on the query string or in the request body" + ex.ToString());
            }

            //foreach (ToDoItem toDoItem in toDoItemsIn)
            //{
            //    log.Info($"Description={toDoItem.Description}");
            //    await toDoItemsOut.AddAsync(toDoItem);
            //}

           
        }
    }
}
