namespace pogoda
{
    public class WeatherDto
    {
        public double temperatura { get; set; }
        public double temperatura_odczuwalna { get; set; }
        public double wiatr { get; set; }
        public double cisnienie { get; set; }
        public string opis { get; set; }
        public string obrazek { get; set; }
        public string lokalizacja { get; set; }
    }
}