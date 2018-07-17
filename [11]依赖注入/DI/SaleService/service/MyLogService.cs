using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.service
{
    public class MyLogService : ILogService
    {
        public Guid _guid;

        public MyLogService()
        {
            _guid = Guid.NewGuid();
        }

        void ILogService.LogInfomation(string info)
        {
            Console.WriteLine($" ==> MyLogService : My Guid is :{_guid}");
            Console.WriteLine($" ==> MyLogService : {DateTime.Now.ToString()}:{info}");
        }
    }

    public static class PPP
    {
        public static void AddMyLog(this IServiceCollection services)
        {
            services.AddSingleton<ILogService, MyLogService>();            
        }
    }

       
}
