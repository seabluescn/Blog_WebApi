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
        private readonly SalesContext _context;
                
        public  ProductsController(SalesContext context)
        {
            _context = context;
        }


        /// <summary>
        /// 获取产品列表
        /// </summary>
        /// <returns>产品列表</returns>
        [HttpGet]
        public List<Product> GetAllProducts()
        {
            List<Product> products = _context.Products.ToList<Product>();

            return products;
        }

        /// <summary>
        /// 根据产品编号查询产品信息（非模糊查询）
        /// </summary>
        /// <param name="code">产品编码</param>
        /// <returns>产品信息</returns>
        [HttpGet("{code}")]  
        public Product GetProductByCode(String code)
        {
            Console.WriteLine($"GetProductByCode：code={code}");

            Product product = _context.Products.Find(code);

            return product;
        }

        /// <summary>
        /// 根据产品名称查询产品信息（非模糊查询）
        /// </summary>
        /// <param name="code">产品名称</param>
        /// <returns>产品信息列表</returns>
        [HttpGet("name")]
        public List<Product> GetProductByName(String name)
        {
            Console.WriteLine($"GetProductByName：name={name}");

            List<Product> products = _context.Products.Where(p => p.Name == name).ToList<Product>();

            //唯一性约束
            //Product product = _context.Products.Where(p => p.Name == name).Single<Product>();

            //模糊查询
            //List<Product> productss = _context.Products.Where(p => EF.Functions.Like(p.Name,$"%{name}%")).ToList<Product>();

            return products;
        }


        /// <summary>
        /// 新增产品
        /// </summary>
        /// <param name="product">产品信息</param>
        [HttpPost]
        public string  AddProduct([FromBody]Product product)
        {
            if(product==null)
            {
                Console.WriteLine("Add product : null");
                return null;
            }

            Console.WriteLine($"Add product :{product.Name}");

            _context.Products.Add(product);
            _context.SaveChanges();

            return "success";
        }

        

        /// <summary>
        /// 删除产品
        /// </summary>
        /// <param name="code">编码</param>
        [HttpDelete("{code}")]
        public void Delete(string  code)
        {
            Console.WriteLine($"Delete product: code={code}");

            Product product = _context.Products.Find(code);            

            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }           

            return;
        }


        /// <summary>
        /// 更新产品信息
        /// </summary>
        /// <param name="code">产品编码</param>
        /// <param name="newproduct">产品信息</param>
        [HttpPut("{code}")]
        public void Update(String code, [FromBody]Product newproduct)
        {
            Console.WriteLine($"Change product ({code}):Name={newproduct.Name}");

            Product product = _context.Products.Find(code);
            product.Name = newproduct.Name;

            _context.SaveChanges();

            return;
        }

    }
}