using BRQ.CreditTest.Application.Services;
using BRQ.CreditTest.Domain.Enums;
using BRQ.CreditTest.Domain.Interfaces;
using EnumsNET;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;


namespace BRQ.CreditTest.ConsoleApp
{
    class Program
    {

        static void  Main(string[] args)
        {

            var builder = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddAutoMapper(typeof(MyApplication).Assembly);
                    services.AddTransient<MyApplication>();
                    services.AddSingleton<ITradeService, TradeService>();

                }).UseConsoleLifetime();

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                try
                {
                    var myService = services.GetRequiredService<MyApplication>();
                    var result = myService.Run();

                    foreach (var item in result)
                    {
                        Console.WriteLine(((Category)item).AsString(EnumFormat.Description));
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Occured");
                }
            }
        }


    }
}
