using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using System;

namespace SEDC.Lamazon.WEB
{
    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                 .Enrich.FromLogContext()
                 .MinimumLevel.Debug()
                 .WriteTo.RollingFile(
                    $@"{AppDomain.CurrentDomain.BaseDirectory}Logs\Lamazon_LOG_{DateTime.UtcNow.Date:dd-MM-yyyy}.txt",
                    LogEventLevel.Debug,
                    "{NewLine}{TimeStamp:HH:mm:ss} [{Level}] ({CorrelationToken}) {Message}{NewLine}{Exception}")
                 .CreateLogger();




            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
