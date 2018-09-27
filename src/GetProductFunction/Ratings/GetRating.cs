using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Results;
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
                Route = "todoitems/{id}")]HttpRequestMessage req,
            [CosmosDB(
                databaseName: "FruitIceCream",
                collectionName: "Ratings",
                ConnectionStringSetting = "CosmosDBConnection",
                Id = "{id}")] Rating ratingItem,
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
            return new OkResult();
        }
    }
}
