using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Functions.Worker.Middleware;

namespace Microsoft.Azure.Functions.Worker.Extensions.Http.AspNetCore
{
    internal class TestMiddleware : IFunctionsWorkerMiddleware
    {
        public async Task Invoke(FunctionContext context, FunctionExecutionDelegate next)
        {
            await next(context);

            // retrieve http context from function context
            HttpContext httpContext = context.GetHttpContext()
                ?? throw new InvalidOperationException($"{nameof(context)} has no http context associated with it.");

            var statusCode = httpContext.Response.StatusCode;

            Console.WriteLine("In the worker, status code is: " + statusCode);

            if (statusCode != 400)
            {
                Console.WriteLine("In worker test middleware, status code is not 400, it is " + statusCode);
            }
        }
 
    }
}
