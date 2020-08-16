using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using nozama.Repository.Book;
using nozama.Util;

namespace nozama
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
