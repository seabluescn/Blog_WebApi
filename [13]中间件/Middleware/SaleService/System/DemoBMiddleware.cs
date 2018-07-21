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
    public class DemoBMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public DemoBMiddleware(RequestDelegate next, ILogger<DemoBMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Response.OnCompleted(ResponseCompletedCallback, context);

            _logger.LogInformation("(2) DemoBMiddleware.Invoke part1");           

            await _next(context);

            context.Response.StatusCode = 401;
            _logger.LogInformation("[2] DemoBMiddleware:Invoke part2");
        }

        private Task ResponseCompletedCallback(object arg)
        {
            _logger.LogInformation("{2} DemoBMiddleware:ResponseCompletedCallback");
            return Task.FromResult(0);
        }
    }
}
