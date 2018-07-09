using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SaleService.Models;

namespace SaleService.Controllers
{
    [Produces("application/json")]
    [Route("api/article")]
    public class ArticleController : Controller
    {
        private readonly SalesContext _context;
        private readonly ILogger _logger;

        public ArticleController(SalesContext context, ILogger<ArticleController> logger)
        {
            _context = context;
            _logger = logger;
        }        

        [HttpGet("logger")]
        public void TestLogger()
        {
            Console.WriteLine("===========TestLogger==============");
           
            _logger.LogCritical("LogCritical");
            _logger.LogError("LogError");           
            _logger.LogWarning("LogWarning");
            _logger.LogInformation("LogInformation");
            _logger.LogDebug("LogDebug");

            return;
        }
    }
}