using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.Models
{
    public class Column
    {
        [Key]
        public string ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public List<Article> Articles { get; set; }
    }
}
