using BlazorApi.Shared.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApi.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddScoped(http => new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
            } );
            
            
            builder.Services.AddScoped<IGameService , GameService>();
           

            await builder.Build().RunAsync();
        }
    }
}
