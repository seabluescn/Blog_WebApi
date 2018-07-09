using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.Models
{
    public class Article
    {
        [Key]
        public string ID { get; set; }

        public string ColumnID { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorID { get; set; }
        public string AuthorName { get; set; }

        public User Author { get; set; }

        public DateTime PostTime { get; set; }
    }
}
