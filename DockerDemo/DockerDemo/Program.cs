using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace DockerDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseUrls("http://*:5000")
            .UseIISIntegration()
            .UseStartup<Startup>();

    }
}
