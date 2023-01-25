namespace MediocreWeatherService.DTO
{
    public class Location
    {
        public string Name { get; set; }
        public LocalNames Local_Names { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
    }

    public class LocalNames
    {
        public string sr { get; set; }
        public string lt { get; set; }
        public string ar { get; set; }
        public string uk { get; set; }
        public string ru { get; set; }
        public string ur { get; set; }
        public string fa { get; set; }
        public string mk { get; set; }
        public string hu { get; set; }
        public string ko { get; set; }
        public string en { get; set; }
        public string zh { get; set; }
    }
}
