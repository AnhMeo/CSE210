using System;

public class OutdoorGatheringEvent : Event
{
    private string _weatherForecast;

    public OutdoorGatheringEvent(string title, string description, DateTime date, DateTime time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string WeatherForecast => _weatherForecast;

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}Weather Forecast: {_weatherForecast}\n";
    }

    public override string GetShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {Title}\nDate: {Date.ToShortDateString()}\n";
    }
}
