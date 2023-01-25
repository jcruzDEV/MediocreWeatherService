using MediocreWeatherService.DTO;
using MediocreWeatherService.DTO.OpenWeather;
using MediocreWeatherService.Services.Interfaces;
using static MediocreWeatherService.DTO.OpenWeather.Forecast;

namespace MediocreWeatherService.Services
{
    public class OpenWeatherService : IOpenWeatherService
    {
        private readonly HttpClient client;
        private readonly string apiKey;

        public OpenWeatherService(IConfiguration configuration)
        {
            client = new();
            apiKey = configuration["OpenWeatherAPIKey"];
        }

        public async Task<IEnumerable<Location>?> GetLocations(LocationSearch locationSearch)
        {
            IEnumerable<Location> locations = null;
            string requestUri = GetGeoRequest(locationSearch);

            HttpResponseMessage response = await client.GetAsync(requestUri);

            if (response.IsSuccessStatusCode)
                locations = await response.Content.ReadAsAsync<IEnumerable<Location>>();

            return locations.Where(x=>x.Country.Contains("US"));
        }
        public async Task<CurrentWeather> GetCurrentWeather(Location location)
        {
            CurrentWeather weatherForecast = new();
            string requestUri = GetCurrentWeatherRequestUri(location);

            HttpResponseMessage response = await client.GetAsync(requestUri);

            if (response.IsSuccessStatusCode)
                weatherForecast = await response.Content.ReadAsAsync<CurrentWeather>();

            return weatherForecast;
        }
        public async Task<WeatherForecast> GetWeatherForecast(Location location)
        {
            WeatherForecast weatherForecast = new();
            string requestUri = GetWeatherForecastRequestUri(location);

            HttpResponseMessage response = await client.GetAsync(requestUri);

            if (response.IsSuccessStatusCode)
                weatherForecast = await response.Content.ReadAsAsync<WeatherForecast>();

            return weatherForecast;
        }
        public async Task<WeatherObject> GetWeather(Location location)
        {
            return new WeatherObject
            {
                Location = location,
                CurrentWeather = await GetCurrentWeather(location),
                Forecast = await GetWeatherForecast(location)
            };
        }

        private string GetWeatherForecastRequestUri(Location location) => $"https://api.openweathermap.org/data/2.5/forecast?lat={location.Lat}&lon={location.Lon}&units=metric&appid={apiKey}";
        private string GetCurrentWeatherRequestUri(Location location) => $"https://api.openweathermap.org/data/2.5/weather?lat={location.Lat}&lon={location.Lon}&units=metric&appid={apiKey}";
        private string GetGeoRequest(LocationSearch locationSearch) => $"https://api.openweathermap.org/geo/1.0/direct?q={locationSearch.Location}&limit=5&appid={apiKey}";
    }
}
