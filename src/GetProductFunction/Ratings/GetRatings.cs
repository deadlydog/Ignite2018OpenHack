using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Functions.Models;

namespace Functions.Ratings
{
    public static class GetRatings
    {
        [FunctionName("GetRatings")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "ratings/{id}")]HttpRequestMessage req, 
            [CosmosDB(
                databaseName: "FruitIcecream",
                collectionName: "Ratings",
                ConnectionStringSetting = "CosmosDBConnection",
                SqlQuery = "select * from Ratings r where r.UserId = {id}")] IEnumerable<Rating> ratingItems, ILogger log)
        {

            log.Log(LogLevel.Information,"C# HTTP trigger function processed a request.");

            return req.CreateResponse(HttpStatusCode.OK, ratingItems);
        }
    }
}
