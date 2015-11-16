using System;
using System.Collections.Generic;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace LotteryTool
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app)
        {
            // Add the platform handler to the request pipeline.
            app.UseIISPlatformHandler();
            
            app.Run(async (context) =>
            {
                List<string> list = new List<string>{"a","b","c"};
                
                list.ForEach(item => {
                    Console.WriteLine("Load WebSit" + item);
                });
                
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
