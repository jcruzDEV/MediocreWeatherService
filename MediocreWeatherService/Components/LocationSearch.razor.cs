using System.ComponentModel;
using MediocreWeatherService.DTO;
using MediocreWeatherService.Services;
using MediocreWeatherService.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace MediocreWeatherService.Components
{
    public partial class LocationSearch : ComponentBase 
    {
        [Inject] OpenWeatherService? OpenWeatherService { get; set; }
        [Parameter] public EventCallback<Location> OnSelectLocation { get; set; }

        DTO.LocationSearch locationSearch = new();
        IEnumerable<Location>? locations;

        private async Task HandleValidSubmit() =>
            locations = await OpenWeatherService.GetLocations(locationSearch);

        private async Task HandleOnSelectLocation(Location location) =>
            await OnSelectLocation.InvokeAsync(location);
    }
}
