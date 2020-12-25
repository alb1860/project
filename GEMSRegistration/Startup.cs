using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using GEMSRegistration.DAL;


namespace GEMSRegistration
{
    public class Startup
    {
        //configuration root object mapping to JSon file and access connection string
        IConfigurationRoot Configuration;

        //custom constructor for the startup class
        public Startup(IHostingEnvironment env)
        {
            //set configuration object = AppSetting.Json File to access connection string
            Configuration = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("appsettings1.json").Build();
            //constructs a configuration object based on the content of the appsettings.json file
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //add DbContext to the System at Startup
            services.AddDbContext<GEMSRegistrationContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles(); // allows us to use the static files in the root directory
            app.UseMvcWithDefaultRoute(); // allows use of default routes
            app.UseDeveloperExceptionPage(); //allows display of developer exceptions 
        }
    
    }
}
