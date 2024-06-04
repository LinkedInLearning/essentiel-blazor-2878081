namespace ExempleAuto.Client.Models
{
    public interface IDataService
    {
        Task<IEnumerable<WeatherForecastDto>> GetAllForecasts();
    }
}
