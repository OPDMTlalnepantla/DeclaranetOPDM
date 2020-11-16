using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace PadronObligados2021
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //ILoggerFactory loggerFactory = new LoggerFactory(
            //                new[] { new ConsoleLoggerProvider((_, __) => true, true) }
            //            );
            //or
            //ILoggerFactory loggerFactory = new LoggerFactory().AddConsole();
            ILoggerFactory loggerFactory = new LoggerFactory();

            ILogger logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("This is log message.");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
