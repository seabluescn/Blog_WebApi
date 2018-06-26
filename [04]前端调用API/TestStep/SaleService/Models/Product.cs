using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.Models
{
    public class Product
    {     
     
        public string Code { get; set; }

        public string Name { get; set; }
        
        public int Numbers { get; set; }

        public User user { get; set; }

        public Product()
        {
            user = new User();
        }

    }
}
