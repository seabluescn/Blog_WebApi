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
        public List<Article> GetAllArticles()
        {
            _logger.LogInformation("GetAllArticles");

            List<Article> articles = null;

            if (!_cache.TryGetValue<List<Article>>("GetAllArticles", out articles))            
            {
                _logger.LogInformation("未找到缓存，去数据库查询");

                articles = _context.Articles
                    .AsNoTracking()
                    .ToList<Article>();

                _cache.Set("GetAllArticles", articles);
            }
            else
            {
                _logger.LogInformation("找到缓存");
            }

            return articles;
        }

        /// <summary>
        /// 查询所有记录//测试绝对过期时间
        /// </summary>
        /// <returns></returns>
        [HttpGet("test1")]
        public List<Article> GetAllArticlesTest1()
        {
            _logger.LogInformation($"GetAllArticlesTest1：{DateTime.Now.ToString()}");

            List<Article> articles = null;

            if (!_cache.TryGetValue<List<Article>>("GetAllArticles", out articles))
            {
                _logger.LogInformation("未找到缓存，去数据库查询");

                articles = _context.Articles
                    .AsNoTracking()
                    .ToList<Article>();

                _cache.Set("GetAllArticles", articles, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromSeconds(20)));
            }
            else
            {
                _logger.LogInformation("找到缓存");
            }

            return articles;
        }

        /// <summary>
        /// 查询所有记录//测试相对过期时间
        /// </summary>
        /// <returns></returns>
        [HttpGet("test21")]
        public List<Article> GetAllArticlesTest2()
        {
            _logger.LogInformation($"GetAllArticlesTest1：{DateTime.Now.ToString()}");

            List<Article> articles = null;

            if (!_cache.TryGetValue<List<Article>>("GetAllArticles", out articles))
            {
                _logger.LogInformation("未找到缓存，去数据库查询");

                articles = _context.Articles
                    .AsNoTracking()
                    .ToList<Article>();

                _cache.Set("GetAllArticles", articles, new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(10)));
            }
            else
            {
                _logger.LogInformation("找到缓存");
            }

            return articles;
        }

    }
}