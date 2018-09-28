using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Functions.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Functions.Ratings
{
    public static class GetRating
    {
        [FunctionName("GetRating")]
        public static HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", 
                Route = "GetRating/{ratingId}")]HttpRequestMessage req,
            [CosmosDB(
                databaseName: "FruitIcecream",
                collectionName: "Ratings",
                ConnectionStringSetting = "CosmosDBConnection",
                Id = "{ratingId}")] Rating ratingItem,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            if (ratingItem == null)
            {
                log.LogInformation($"Rating item not found");
            }
            else
            {
                log.LogInformation($"Found Rating item, Description={ratingItem.RatingValue}");
            }
            return req.CreateResponse (HttpStatusCode.OK, ratingItem);
        }
    }
}
