using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SaleService.Controllers;
using SaleService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.System
{
    public class MyMvcMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public MyMvcMiddleware(RequestDelegate next, ILogger<DemoAMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation("MyMVCMiddleware.Invoke");


            var obj = context.RequestServices.GetRequiredService<ArticleController>().GetArticleList();
            var str = JsonConvert.SerializeObject(obj);
            await context.Response.WriteAsync(str);
        }
    }
}
