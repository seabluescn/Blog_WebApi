using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NLog.Extensions.Logging;
using SaleService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.System.Middleware
{
    public class UserAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        private readonly IMemoryCache _cache;

        public UserAuthenticationMiddleware(RequestDelegate next, ILogger<UserAuthenticationMiddleware> logger, IMemoryCache memoryCache)
        {
            _next = next;
            _logger = logger;
            _cache = memoryCache;
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation($"context.Request.Path={context.Request.Path}");

            //如果是登陆接口就不需要验证Tocken
            if (context.Request.Path.ToString().ToLower().StartsWith("/api/user/login"))
            {
                await _next(context);
                return;
            }

            if (context.Request.Path.ToString().ToLower().StartsWith("/api/"))
            {
                string tockenid = context.Request.Query["tockenid"];

                if (tockenid == null)
                {  
                    var result = new ResultObject
                    {
                        state = ResultState.Exception,
                        ExceptionString = "Need tockenid"
                    };

                    context.Response.ContentType = "application/json; charset=utf-8";
                    context.Response.WriteAsync(JsonConvert.SerializeObject(result));
                    return;
                }               

                User user = null;
                if (!_cache.TryGetValue(tockenid, out user))
                {    
                    context.Response.StatusCode = 401;
                    context.Response.ContentType = "application/json; charset=utf-8";
                    context.Response.WriteAsync("Invalidate tockenid(用户认证失败)");

                    return;
                }
            }

            await _next(context);
        }


    }

    public static class UserAuthenticationMiddlewareExtensions
    {
        public static IApplicationBuilder UseUserAuthentication(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UserAuthenticationMiddleware>();
        }
    }

}
