using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using UseHangfire.Tasks;

namespace UseHangfire.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet("do1")]
        public string GetDo1()
        {   
            BackgroundJob.Enqueue<TimedTaskService>(t => t.DoSomeThing1());

            return "success";
        }

        [HttpGet("do2")]
        public string GetDo2()
        {           
            BackgroundJob.Enqueue<TimedTaskService>(t => t.DoSomeThing2());

            return "success";
        }


    }
}
