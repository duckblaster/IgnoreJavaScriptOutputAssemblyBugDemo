using DemoApp.Shared.Services;
using DemoApp.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace DemoApp.Web.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Add device-specific services used by the DemoApp.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();

            await builder.Build().RunAsync();
        }
    }
}
