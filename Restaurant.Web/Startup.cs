using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Restaurant.Data;
using Restaurant.Web.Hubs;

namespace Restaurant.Web
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
           _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
            services.AddDbContextPool<RestaurantDbContext>(dbContextOptions => 
            {
                dbContextOptions.UseSqlServer(_configuration.GetConnectionString("RestaurantDBConnectionString"));
            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<FoodsHub>("/FoodsHub");
            });
        }
    }
}
