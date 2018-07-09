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
    [Route("api/Article")]
    public class ArticleController : Controller
    {
        private readonly SalesContext _context;
        private readonly ILogger _logger;

        public ArticleController(SalesContext context, ILogger<ArticleController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Article> GetAllArticles()
        {
            Console.WriteLine("GetAllArticles");

            int pageSize = 10;
            int pageNumber = 2;
           
            List<Article> articles = _context.Articles
                .AsNoTracking()
                .Skip(pageSize* pageNumber)
                .Take(pageSize)
                .ToList<Article>();

            return articles;
        }

        /// <summary>
        /// 根据主键查询记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Article GetArticleByID(string id)
        {
            //Article article = _context.Articles.Find(id);

            Article article = _context.Articles
                .AsNoTracking()
                .Include(a => a.Author)
                .First();

            return article;
        }

        /// <summary>
        /// 根据标题模糊查询
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        [HttpGet("title")]
        public List<Article> GetArticleByTitle(string title)
        {
            List<Article> articles = null;

            Console.WriteLine("通过Contains比较");
            articles = _context.Articles.Where(article => article.Title.Contains(title)).ToList();

            Console.WriteLine("通过EF.Functions.Like");
            articles = _context.Articles
                .AsNoTracking()
                .Where(article => EF.Functions.Like(article.Title,$"{title}%"))              
                .ToList();

            return articles;
        }

        /// <summary>
        /// 演示原生SQL查询
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        [HttpGet("code")]
        public List<Article> GetArticleByTitleWithSQL(string code)
        {
            //if code = XXX' or '1'='1 会引起SQL注入
            var sql = $"select * from cms_article where ID = '{code}'";
                     
            List<Article> articles = _context.Articles
                .AsNoTracking()
                .FromSql(sql)             
                .ToList();

            return articles;
        }

      
    }
}