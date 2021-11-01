using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                context.Items.Add("text", "КІ2с-20-1 ТОП");
                await next.Invoke();
            });

            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/html; charset=utf-8";
                if (context.Items.ContainsKey("text"))
                    await context.Response.WriteAsync($"Текст: {context.Items["text"]}");
                else
                    await context.Response.WriteAsync("Случайный текст");
            });
        }
    }
}
