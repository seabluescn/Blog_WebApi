using Microsoft.AspNetCore.Mvc;
using SaleService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.Controllers
{
    [Produces("application/json")]
    [Route("api/newproduct")]
    public class NewProductController : Controller
    {
        [HttpPost("t1")]
        public void PostData1(string name,string code,[FromBody]Product product)
        {
            Console.WriteLine("t1/PostData");
            Console.WriteLine($"name={name}");
            Console.WriteLine($"code={code}");
            Console.WriteLine($"ProductName={product.ProductName}");
        }

        [HttpPost("t2")]
        public void PostData2(string name, string code,Product product)
        {
            Console.WriteLine("t2/PostData");
           
            Console.WriteLine($"code={code}");
            Console.WriteLine($"name={name}");
           
            Console.WriteLine($"ProductCode={product.ProductCode}");
            Console.WriteLine($"ProductName={product.ProductName}");
        }
    }
}
