using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECOMMERCE.ApplicationCore.Interfaces.InterfaceDrink;
using ECOMMERCE.Infrastructure.Data.Mock;
using ECOMMERCE.Infrastructure.Data.Mock.MockDrink;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ECOMMERCEDRIK
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IDrinkRepository, MockDrinkRepository>();
            services.AddTransient<ICategoryRepository, MockCategoryRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "/{controller=Home}/{action/Index}/{id?}");

            });
        } 
    }
}
