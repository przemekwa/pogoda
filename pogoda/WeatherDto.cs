namespace pogoda
{
    public class WeatherDto
    {
        public double Temperature { get; set; }
        public double TemperatureFeel { get; set; }
        public double Wind { get; set; }
        public double Pressure { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }
    }
}