namespace OlympicGamesWebApp.Models
{
    public class Country
    {
        public string CountryId { get; set; }
        public string CountryName { get; set; }
        public Game Game { get; set; }
        public Sport Sport { get; set; }
        public Type Type { get; set; }
        public string FlagImg { get; set; }
    }
}
