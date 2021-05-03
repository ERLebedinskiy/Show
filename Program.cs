using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcLibrary.Data;

namespace MvcLibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //XmlFileWriteAndRead.xmlWriteBookFiles("Book4", 10);
            //XmlFileWriteAndRead.xmlReadFromBookFiles("Book4");
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
