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
        /// 根据主键查询记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ResultObject GetArticleByID(string id)
        {
            try
            {
                int idn = int.Parse(id);

                Article article = _context.Articles
                    .AsNoTracking()
                    .Where(a => a.ID == id)
                    .Single();

                return new ResultObject
                {
                    result = article
                };
            }
            catch (FormatException ex)
            {
                _logger.LogError(ex.Message + "\n" + ex.StackTrace);

                return new ResultObject
                {
                    state = ResultState.Exception,
                    ExceptionString = "id必须为数字"
                };
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError(ex.Message + "\n" + ex.StackTrace);

                return new ResultObject
                {
                    state = ResultState.Exception,
                    ExceptionString = "未查询到预料的数据"
                };
            }
           

        }

        /// <summary>
        /// 根据标题模糊查询
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        [HttpGet("title")]
        public ResultObject GetArticleByTitle(string title)
        {

            List<Article> articles = _context.Articles
                 .AsNoTracking()
                 .Where(article => EF.Functions.Like(article.Title, $"{title}%"))
                 .ToList();

            return new ResultObject
            {
                result = articles
            };
        }

    }
}