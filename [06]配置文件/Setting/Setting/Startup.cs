using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Setting.Modal;

namespace WebApplication4
{
    public class Startup
    {
        public Startup(IConfiguration configuration,IHostingEnvironment env)
        {
            Configuration = configuration;
            _env = env;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment _env { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //services.AddOptions();
            //services.Configure<SystemConfig>(Configuration.GetSection("SystemConfig"));

            var rootpath = _env.ContentRootPath;
            Console.WriteLine("rootpath=" + rootpath);

            var builder = new ConfigurationBuilder()
               .SetBasePath(_env.ContentRootPath)
               .AddJsonFile("mysetting.json",optional: true, reloadOnChange: true)
               .AddEnvironmentVariables();
            var MyConfiguration = builder.Build();

            services.AddOptions();
            services.Configure<SystemConfig>(MyConfiguration.GetSection("SystemConfig"));


            var ConnString = Configuration["ConnString"];
            Console.WriteLine("ConnString=" + ConnString);

            var UploadFile = Configuration.GetSection("SystemConfig")["UploadFile"];
            Console.WriteLine("UploadFile=" + UploadFile);

            var AdminName = Configuration.GetSection("SystemConfig").GetSection("Admin")["Name"];
            Console.WriteLine("AdminName=" + AdminName);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
