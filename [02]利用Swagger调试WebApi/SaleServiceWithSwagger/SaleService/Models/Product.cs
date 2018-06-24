using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.Models
{
    public class Product
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescript { get; set; }
        public int ProductPrice4Buy { get; set; }
        public int ProductPrice4Sale { get; set; }
        public int ProductNumbers { get; set; }
    }
}
