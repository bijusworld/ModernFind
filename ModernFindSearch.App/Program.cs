using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ModernFindSearch.App.Services;
using System;
using System.Threading.Tasks;

namespace ModernFindSearch.App
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient<ICustomerDataService, CustomerDataService>(client => client.BaseAddress = new Uri("https://localhost:44327/"));
            builder.Services.AddHttpClient<IProductDataService, ProductDataService>(client => client.BaseAddress = new Uri("https://localhost:44327"));

            await builder.Build().RunAsync();
        }
    }
}
