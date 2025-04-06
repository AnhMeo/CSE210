
    public class OutdoorGathering : Event
    {
        public string WeatherForecast { get; }

        public OutdoorGathering(string title, string description, DateTime eventDate, Address eventAddress, string weatherForecast)
            : base(title, description, eventDate, eventAddress)
        {
            WeatherForecast = weatherForecast;
        }

        public override string FullDetails()
        {
            return $"{StandardDetails()}\nEvent Type: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
        }
    }
