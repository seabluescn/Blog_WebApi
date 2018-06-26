using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaleService.Models;

/// <summary>
/// Write by seabluescn
/// 2018-5-22
/// </summary>
namespace SaleService.Controllers
{
    /// <summary>
    /// 产品信息接口    
    /// </summary>
    [Produces("application/json")]  
    [Route("api/products")]
    public class ProductsController : Controller
    {        
        [HttpPost]
        public string  AddProduct(String Code,Product product)
        {
            Console.WriteLine($"Code :{Code}");

            if (product==null)
            {
                Console.WriteLine("Add product : null");
                return null;
            }

            Console.WriteLine($" product code :{product.Code}");
            Console.WriteLine($" product name :{product.Name}");
            Console.WriteLine($" product.user.Name :{product.user.Name}");

            return "success";
        }      
        
       

    }
}