using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SpringBoot.Entities;
using Microsoft.EntityFrameworkCore;
using SpringBoot.Services;
using SpringBoot.Repositories;

namespace SpringBoot
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<CarContext>(options => options.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = SpringBoot; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"));
            services.AddScoped<CarService>();
            services.AddScoped<CarRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseStaticFiles();
        }
    }
}
