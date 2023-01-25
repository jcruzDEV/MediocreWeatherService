namespace MediocreWeatherService.DTO.OpenWeather
{
    public class WeatherObject
    {
        public Location Location { get; set; }
        public CurrentWeather CurrentWeather { get; set; }
        public Forecast.WeatherForecast Forecast { get; set; }
    }
}
