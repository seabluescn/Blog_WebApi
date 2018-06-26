using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.Models
{
    [Serializable]
    public class Product
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescript { get; set; }
        public int ProductNumbers { get; set; }

        public Product(string code,string name)
        {
            ProductCode = code;
            ProductName = name;
        }
        public Product()
        {            
        }
    }
}
