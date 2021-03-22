using Microsoft.Extensions.Hosting;

namespace Factory
{
    public class Program
    {
        static async void Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            await host.RunAsync();
        }

        static IHostBuilder CreateHostBuilder(string[] args)
        => Host.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
    }
}
