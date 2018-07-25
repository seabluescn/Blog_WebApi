using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using SaleService.Models;

namespace SaleService.Controllers
{
    [Produces("application/json")]
    [Route("api/Article")]
    public class ArticleController : Controller
    {
        private readonly SalesContext _context;
        private readonly ILogger _logger;
        private readonly IMemoryCache _cache;

        public ArticleController(SalesContext context, ILogger<ArticleController> logger, IMemoryCache memoryCache)
        {
            _context = context;
            _logger = logger;
            _cache = memoryCache;
        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ResultObject GetAllArticles(string tockenid)
        {
            _logger.LogInformation("GetAllArticles");                         

            List<Article> articles = _context.Articles
                    .AsNoTracking()
                    .ToList<Article>();          

            return new ResultObject
            {
                state = ResultState.Success,
                result = articles
            };
        }      


    }
}