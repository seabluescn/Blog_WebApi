using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        /// <summary>
        /// 获取产品列表
        /// </summary>
        /// <returns>产品列表</returns>
        [HttpGet]
        public List<Product> GetList()
        {
            Product p1 = new Product();
            p1.ProductCode = "1001";
            p1.ProductName = "洗发水";

            Product p2 = new Product();
            p2.ProductCode = "1002";
            p2.ProductName = "洗面奶";

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);

            return products;
        }

        /// <summary>
        /// 根据产品编号查询产品信息
        /// </summary>
        /// <param name="code">产品编码</param>
        /// <returns>产品信息</returns>
        [HttpGet("{code}")]  
        public Product GetProduct(String code)
        {
            var product = new Product
            {
                ProductCode = code,
                ProductName = "啫喱水"
            };

            return product;
        }

        /// <summary>
        /// 新增产品
        /// </summary>
        /// <param name="product">产品信息</param>
        [HttpPost]
        public void AddProduct([FromBody]Product product)
        {
            Console.WriteLine(product.ProductName);
            return;
        }
    }
}