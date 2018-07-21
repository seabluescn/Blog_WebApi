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
    public class RequestRecordMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public RequestRecordMiddleware(RequestDelegate next, ILogger<RequestRecordMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation("(3) RequestRecordMiddleware.Invoke");

            String URL = context.Request.Path.ToString();
            _logger.LogInformation($"URL : {URL}");
            
            context.Response.OnCompleted(ResponseCompletedCallback, context);

            await _next(context);

            _logger.LogInformation("[3] RequestRecordMiddleware:Invoke next");
            _logger.LogInformation($"[3]StatusCode : {context.Response.StatusCode}");
        }

        private Task ResponseCompletedCallback(object arg)
        {
            _logger.LogInformation("{3} RequestRecordMiddleware:ResponseCompletedCallback");

            HttpContext context = (HttpContext)arg;

            _logger.LogInformation($"3StatusCode : {context.Response.StatusCode}");

            return Task.FromResult(0);
        }
    }

    public static class RequestRecordMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestRecord(this IApplicationBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException("builder is null");
            }

            return builder.UseMiddleware<RequestRecordMiddleware>();
        }
    }
}
