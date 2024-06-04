using ExempleAuto.Client.Models;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<IDataService, ClientDataService>();
await builder.Build().RunAsync();

class ClientDataService : IDataService
{
    public async Task<IEnumerable<WeatherForecastDto>> GetAllForecasts()
    {
        // Simule le return await http.GetFromJsonAsync<WeatherForecastDto[]>(...)
        await Task.Delay(1000);
        return WeatherForecastDto.Generer(3);
    }
}
