using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SaleService.Models;

namespace SaleService.Controllers
{
    [Produces("application/json")]
    [Route("api/Article")]
    public class ArticleController : Controller
    {
        private readonly SalesContext _context;
        private readonly ILogger _logger;
        private readonly IMemoryCache _memoryCache;
        private readonly IDistributedCache _distributedCache;


        public ArticleController(SalesContext context, ILogger<ArticleController> logger, IMemoryCache memoryCache, IDistributedCache distributedCache)
        {
            _context = context;
            _logger = logger;
            _memoryCache = memoryCache;
            _distributedCache = distributedCache;
        }

 

        /// <summary>
        /// 查询所有记录//利用Redis进行缓存字符串
        /// </summary>
        /// <returns></returns>
        [HttpGet("redis")]
        public void TestRedis()
        {
            _logger.LogInformation($"TestRedis：{DateTime.Now.ToString()}");

            String tockenid = "AAAaaaCCA123456dd789B12347";
       
            string infostr =  _distributedCache.GetString(tockenid);

            if(infostr == null)
            {
                _logger.LogInformation("未找到缓存，写入Redis");                               
                _distributedCache.SetString(tockenid, "hello,0601",
                    new DistributedCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromSeconds(10))); 
            }
            else
            {
                _logger.LogInformation("找到缓存");
               
                _logger.LogInformation($"infostr={infostr}");
            }           

            return;
        }

        /// <summary>
        /// 查询所有记录//利用Redis进行缓存对象
        /// </summary>
        /// <returns></returns>
        [HttpGet("redis_object")]
        public List<Article> TestRedis4Object()
        {
            _logger.LogInformation($"TestRedis4Object：{DateTime.Now.ToString()}");

            String objectid = "articles";

            List<Article> articles = null;

            var valuebytes = _distributedCache.Get(objectid);

            if (valuebytes == null)
            {
                _logger.LogInformation("未找到缓存，写入Redis");

                articles = _context.Articles.AsNoTracking().ToList();

                byte[] serializedResult = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(articles));
                _distributedCache.Set(objectid, serializedResult);

                return articles;
            }
            else
            {
                _logger.LogInformation("找到缓存");

                articles =JsonConvert.DeserializeObject<List<Article>>(Encoding.UTF8.GetString(valuebytes));

                return articles;
            }          
        }




    }
}