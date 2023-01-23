using MediocreWeatherService.DTO;
using MediocreWeatherService.Services.Interfaces;

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

            return locations;
        }

        private string GetGeoRequest(LocationSearch locationSearch) => $"https://api.openweathermap.org/geo/1.0/direct?q={locationSearch.Location}&limit=5&appid={apiKey}";
    }
}
