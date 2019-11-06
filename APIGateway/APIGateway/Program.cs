using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace APIGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Run();
        }

        public static IWebHost CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://*:8800")
                .ConfigureAppConfiguration((hostingContext, builder) =>
                {
                    builder.AddJsonFile("configuration.json", false, true);
                }).Build();
    }
}
