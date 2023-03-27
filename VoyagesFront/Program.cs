using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Voyages;

namespace VoyagesFront
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddApiAuthorization();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Logging.AddConfiguration(builder.Configuration.GetSection("Logging"));
            builder.Services.AddSingleton<IDataContext>(s => new DataContext());
            builder.Services.AddLocalization();

            await builder.Build().RunAsync();
        }
    }
}