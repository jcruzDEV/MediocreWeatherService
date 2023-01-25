using MediocreWeatherService.DTO;
using MediocreWeatherService.DTO.OpenWeather;

namespace MediocreWeatherService.Services.Interfaces
{
    public interface IOpenWeatherService
    {
        Task<IEnumerable<Location>?> GetLocations(LocationSearch locationSearch);
        Task<CurrentWeather> GetCurrentWeather(Location location);
        Task<Forecast.WeatherForecast> GetWeatherForecast(Location location);
        Task<WeatherObject> GetWeather(Location location);
    }
}
