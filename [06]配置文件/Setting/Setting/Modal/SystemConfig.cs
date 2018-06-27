using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Setting.Modal
{
    public class SystemConfig
    {
        public String UploadFile { get; set; }       
        public String AnnexUrl { get; set; }
        public User Admin { get; set; }
        public String DefaultPassword { get; set; }
    }

    public class User
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public bool Allow { get; set; }
    }
}
