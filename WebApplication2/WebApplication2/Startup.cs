using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebApplication2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Run(async (context) =>
            {
                string login;
                if (context.Request.Cookies.TryGetValue("name", out login))
                {
                    await context.Response.WriteAsync($"Hello {login}!");
                }
                else
                {
                    context.Response.Cookies.Append("name", "Vlad");
                    await context.Response.WriteAsync("KI2c-20-1!");
                }
            });
        }
    }
}
