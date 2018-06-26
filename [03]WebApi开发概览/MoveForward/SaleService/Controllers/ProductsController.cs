using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleService.Models;
using Microsoft.AspNetCore.Mvc.Formatters;

/// <summary>
/// Write by seabluescn
/// 2018-5-22
/// </summary>
namespace SaleService.Controllers
{
    /// <summary>
    /// 产品信息接口    
    /// </summary>
   
    [Route("api/products")]
    public class ProductsController : Controller
    {
      
        [HttpGet]
        public List<Product> GetProduct()
        {
            Console.WriteLine("GetProduct,My Route:api/products");
            List<Product> products = new List<Product>
            {
                new Product("111","AAA"),
                new Product("2222","BBBB")
            };

            return products;
        }    
        
        [HttpGet("version1")]
        public string GetVersion1()
        {
            return "version:1.0.1";
        }

        [HttpGet("version2")]
        public ContentResult GetVersion2()
        {
            return  Content("version:1.0.1");
        }

    }
}