using System;
using System.Threading.Tasks;
using Factory.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Factory
{
    public static class Program
    {
        public static Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            RunFactoryService(host.Services);
            return host.RunAsync();            
        }

        static IHostBuilder CreateHostBuilder(string[] args)
        => Host.CreateDefaultBuilder(args)
            .UseStartup<Startup>();

        static void RunFactoryService(IServiceProvider services)
        {
            Console.WriteLine("Informe a localização: ");
            var input = Console.ReadLine();

            var repository = services
                .GetRequiredService<ISchoolFactory>()
                .Create(input);

            var result = repository.ConsultAverage().Result;
            Console.WriteLine(result.ToString());
        }
    }
}
