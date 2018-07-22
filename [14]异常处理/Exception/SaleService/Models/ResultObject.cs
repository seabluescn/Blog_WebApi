using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.Models
{
    public class ResultObject
    {
        public ResultObject()
        {
            state = ResultState.Success;
            ExceptionString = "";
            result = null;
        }

        public ResultState state { get; set; }
        public String ExceptionString { get; set; }

        public Object result { get; set; }
    }

    public enum ResultState
    {
        Success,
        Exception
    }
}
