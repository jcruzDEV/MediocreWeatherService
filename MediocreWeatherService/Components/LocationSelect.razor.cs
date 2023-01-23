using MediocreWeatherService.DTO;
using Microsoft.AspNetCore.Components;

namespace MediocreWeatherService.Components
{
    public partial class LocationSelect : ComponentBase
    {
        [Parameter] public IEnumerable<Location> Locations { get; set; }
        [Parameter] public EventCallback<Location> OnSelectLocation { get; set; }
    }
}
