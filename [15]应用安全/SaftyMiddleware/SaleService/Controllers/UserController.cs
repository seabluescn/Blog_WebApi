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
using SaleService.System.Utils;

namespace SaleService.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly SalesContext _context;
        private readonly ILogger _logger;
        private readonly IMemoryCache _cache;


        public UserController(SalesContext context, ILogger<ArticleController> logger, IMemoryCache memoryCache)
        {
            _context = context;
            _logger = logger;
            _cache = memoryCache;
        }

       

        [HttpPost("login")]
        public ResultObject Login(string loginname,string password)
        {
            try
            {
                User user = _context.Users
                    .AsNoTracking()
                    .Where(a => a.LoginName == loginname && a.Password == password)
                    .Single();

                String tockenid = Tocken.GetTockenID();

                _cache.Set(tockenid, user, new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(20)));

                return new ResultObject
                {
                    state = ResultState.Success,
                    result = tockenid
                };
            }
            catch(InvalidOperationException ex)
            {
                return new ResultObject
                {
                    state = ResultState.Exception,
                    ExceptionString = "未找到匹配的数据"
                };
            }           
        }
    }
}