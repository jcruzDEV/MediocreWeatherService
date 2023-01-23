using System.ComponentModel.DataAnnotations;

namespace MediocreWeatherService.DTO
{
    public class LocationSearch
    {
        [Required]
        public string? Location { get; set; }
    }
}
