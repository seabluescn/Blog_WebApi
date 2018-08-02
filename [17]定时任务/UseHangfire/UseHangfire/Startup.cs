using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using UseHangfire.Tasks;
using Hangfire.MySql.Core;

namespace UseHangfire
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddHangfire(x => x.UseStorage(new MemoryStorage()));

            //Redis
            //var connectionString = "58.220.197.198:1987,allowAdmin=true,password=,defaultdatabase=10";
            //services.AddHangfire(x => x.UseRedisStorage(connectionString));

            //MySQL
            //var connectionString = "Server=58.220.197.198;port=3317;database=hangfire;uid=root;pwd=root207;SslMode=None;Allow User Variables=true;";
            //services.AddHangfire(x => x.UseStorage(new MySqlStorage(connectionString)));           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
          
            app.UseHangfireServer();
            app.UseHangfireDashboard();

            RecurringJob.AddOrUpdate(() => Console.WriteLine("hello"), Cron.Minutely());                 


            TimedTaskService service = new TimedTaskService();
            RecurringJob.AddOrUpdate(() => service.SendMessage(), Cron.Minutely());        
        }
    }
}
