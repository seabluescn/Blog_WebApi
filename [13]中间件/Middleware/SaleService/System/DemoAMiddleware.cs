using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SaleService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.System
{
    public class DemoAMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public DemoAMiddleware(RequestDelegate next, ILogger<DemoAMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation("(1) DemoAMiddleware.Invoke front");

            context.Response.OnCompleted(ResponseCompletedCallback, context);

            await _next(context);

            _logger.LogInformation("[1] DemoAMiddleware:Invoke back");
        }

        private Task ResponseCompletedCallback(object arg)
        {
            _logger.LogInformation("{1} DemoAMiddleware:ResponseCompletedCallback");
            return Task.FromResult(0);
        }
    }
}
