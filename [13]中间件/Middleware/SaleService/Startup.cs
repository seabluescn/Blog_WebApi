using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.EntityFrameworkCore;
using NLog.Extensions.Logging;
using NLog.Web;
using SaleService.System;
using SaleService.Controllers;

namespace SaleService
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
          
            String connStr = Configuration.GetConnectionString("MySQLConnection");
            services.AddDbContextPool<SalesContext>(builder=> builder.UseMySQL(connStr));

            services.AddScoped<ArticleController>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseUnifyException();                   

            app.UseRequestRecord();
            app.UseMiddleware<DemoAMiddleware>();
            app.UseMiddleware<DemoBMiddleware>();

            app.UseMiddleware<MyMvcMiddleware>();

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
