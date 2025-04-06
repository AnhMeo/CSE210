using System;

public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private DateTime _time;
    private Address _address;

    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string Title => _title;
    public string Description => _description;
    public DateTime Date => _date;
    public DateTime Time => _time;
    public Address Address => _address;

    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time.ToShortTimeString()}\nAddress: {_address.GetFullAddress()}\n";
    }

    public virtual string GetFullDetails()
    {
        return $"{GetStandardDetails()}Type: General Event\n";
    }

    public virtual string GetShortDescription()
    {
        return $"Type: General Event\nTitle: {_title}\nDate: {_date.ToShortDateString()}\n";
    }
}
