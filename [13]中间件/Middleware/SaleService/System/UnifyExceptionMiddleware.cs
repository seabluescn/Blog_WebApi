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
    public class UnifyExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public UnifyExceptionMiddleware(RequestDelegate next, ILogger<UnifyExceptionMiddleware> logger)
        {
            _next = next;
            _logger=logger;
    }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(Exception ex)
            {
                _logger.LogError($"系统发生未处理异常：{ex.StackTrace}");

                ResultObject result = new ResultObject
                {
                    state = ResultState.Exception,
                    ExceptionString = "系统发生未处理异常"
                };

                context.Response.StatusCode = 200;
                context.Response.ContentType = "application/json; charset=utf-8";
                context.Response.WriteAsync(JsonConvert.SerializeObject(result));
            }
        }

    }

    public static class UnifyExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseUnifyException(this IApplicationBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException("builder is null");
            }

            return builder.UseMiddleware<UnifyExceptionMiddleware>();
        }
    }
}
