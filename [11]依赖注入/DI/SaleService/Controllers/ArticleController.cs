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
using SaleService.service;

namespace SaleService.Controllers
{
    [Produces("application/json")]
    [Route("api/Article")]
    public class ArticleController : Controller
    { 
        private readonly ILogService _myLog;

        public ArticleController(ILogService myLog)
        {  
            _myLog = myLog;
        }        

        [HttpGet("logger")]
        public void TestMyLogger(string logger)
        {
            _myLog.LogInfomation("ArticleController:TestMyLogger");          

            return;
        }
    }
}