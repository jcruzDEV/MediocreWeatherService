﻿using Newtonsoft.Json;

namespace MediocreWeatherService.DTO.OpenWeather
{
    public class Forecast
    {
        public class WeatherForecast
        {
            public string Cod { get; set; }
            public int Message { get; set; }
            public int Cnt { get; set; }
            public List<List> List { get; set; }
            public City City { get; set; }
        }

        public class City
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Coord Coord { get; set; }
            public string Country { get; set; }
            public int Population { get; set; }
            public int Timezone { get; set; }
            public int Sunrise { get; set; }
            public int Sunset { get; set; }
        }

        public class Clouds
        {
            public int All { get; set; }
        }

        public class Coord
        {
            public double Lat { get; set; }
            public double Lon { get; set; }
        }

        public class List
        {
            public int Dt { get; set; }
            public Main Main { get; set; }
            public List<Weather> Weather { get; set; }
            public Clouds Clouds { get; set; }
            public Wind Wind { get; set; }
            public int Visibility { get; set; }
            public double Pop { get; set; }
            public Sys Sys { get; set; }
            public string Dt_txt { get; set; }
            public Rain Rain { get; set; }
        }

        public class Main
        {
            public double Temp { get; set; }
            public double Feels_Like { get; set; }
            public double Temp_Min { get; set; }
            public double Temp_Max { get; set; }
            public int Pressure { get; set; }
            public int Sea_Level { get; set; }
            public int Grnd_Level { get; set; }
            public int Humidity { get; set; }
            public double Temp_Kf { get; set; }
        }

        public class Rain
        {
            [JsonProperty("3h")]
            public double _3h { get; set; }
        }

        public class Sys
        {
            public string Pod { get; set; }
        }

        public class Weather
        {
            public int Id { get; set; }
            public string Main { get; set; }
            public string Description { get; set; }
            public string Icon { get; set; }
        }

        public class Wind
        {
            public double Speed { get; set; }
            public int Deg { get; set; }
            public double Gust { get; set; }
        }
    }
}
