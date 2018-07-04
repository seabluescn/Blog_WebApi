using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.Models
{
    public class Product
    {      
        [Key]
        public string Code { get; set; }

        public string Name { get; set; }

        public string Descript { get; set; }

        public int Numbers { get; set; }

    }
}
