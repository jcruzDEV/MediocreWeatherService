using MediocreWeatherService.DTO;

namespace MediocreWeatherService.Services.Interfaces
{
    public interface IOpenWeatherService
    {
        Task<IEnumerable<Location>?> GetLocations(LocationSearch locationSearch);
    }
}
