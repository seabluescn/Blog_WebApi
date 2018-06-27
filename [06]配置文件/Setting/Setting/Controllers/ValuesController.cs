using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Setting.Modal;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IConfiguration _configuration;
        private IOptions<SystemConfig> _setting;

        public ValuesController(IConfiguration configuration,   IOptions<SystemConfig> setting)
        {
            _configuration = configuration;
            _setting = setting;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var ConnString = _configuration["ConnString"];
            Console.WriteLine("ConnString=" + ConnString);

            var UploadFile = _configuration.GetSection("SystemConfig")["UploadFile"];
            Console.WriteLine("UploadFile=" + UploadFile);

            var AdminName = _configuration.GetSection("SystemConfig").GetSection("Admin")["Name"];
            Console.WriteLine("AdminName=" + AdminName);

            return new string[] { "value1", "value2" };
        }

        [HttpGet("setting")]
        public IEnumerable<string> GetSetting()
        {
            var UploadFile = _setting.Value.UploadFile;
            Console.WriteLine("UploadFile=" + UploadFile);

            var AdminName = _setting.Value.Admin.Name;
            Console.WriteLine("AdminName=" + AdminName);

            var AdminAge = _setting.Value.Admin.Age;
            Console.WriteLine("AdminAge=" + AdminAge);

            var AdminAllow = _setting.Value.Admin.Allow;
            Console.WriteLine("AdminAllow=" + AdminAllow);

            

            return new string[] { "value1", "value2" };
        }


    }
}
