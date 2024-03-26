using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AspNetIntegration
{
    public class BugTest
    {
        private readonly ILogger<BugTest> _logger;

        public BugTest(ILogger<BugTest> logger)
        {
            _logger = logger;
        }

        [Function("bugtest")]
        public IActionResult Run(
                   [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "endpoints/bugtest")] HttpRequest req)
        {
            return new CustomContentResult()
            {
                Content = "{\"Data\":null,\"Success\":false}",
                ContentType = "application/json; charset=utf-8",
                StatusCode = (int)HttpStatusCode.BadRequest,
            };
        }
    }
}
