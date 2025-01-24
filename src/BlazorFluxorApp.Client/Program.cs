using BlazorFluxorApp.Client.Contexts;
using BlazorFluxorApp.Stores.Actions;
using Fluxor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorFluxorApp.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);


            builder.Services.AddFluxor(o =>
            {
                o.ScanAssemblies(typeof(IncrementCounterAction).Assembly);
            });

            builder.Services.AddScoped<TemperatureStore>();

            await builder.Build().RunAsync();
        }
    }
}
