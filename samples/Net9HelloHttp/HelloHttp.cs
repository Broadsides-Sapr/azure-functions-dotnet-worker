using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Net9HelloHttp
{
    public class HelloHttp
    {
        private readonly ILogger<HelloHttp> _logger;

        public HelloHttp(ILogger<HelloHttp> logger)
        {
            _logger = logger;
        }

        [Function("hellohttp")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {       
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Net9 Azure Functions!");
        }
    }
}
