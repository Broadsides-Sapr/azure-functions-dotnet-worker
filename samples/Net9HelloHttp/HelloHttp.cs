using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Net9HelloHttp
{
    public sealed class HelloHttp
    {
        private readonly ILogger _logger;

        public HelloHttp(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<HelloHttp>();
        }

        [Function("HelloHttp")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous)] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}
