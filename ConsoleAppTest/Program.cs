using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ConsoleAppTest.Services;
    
namespace ConsoleAppTest
{   
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("TEST");
            using IHost host = Host.CreateDefaultBuilder(args)
                    .ConfigureServices(services =>
                    {
                        services.AddSingleton<IGreetingService, GreetingService>();
                        services.AddHostedService<MyWorker>();
                    })
                    .Build();

            await host.RunAsync();
        }
    }
}
 