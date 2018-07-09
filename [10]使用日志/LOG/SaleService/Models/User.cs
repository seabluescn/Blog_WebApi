using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.Models
{
    public class User
    {
        [Key]
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public int State { get; set; }
    }
}
