using System;

public class ReceptionEvent : Event
{
    private string _rsvpEmail;

    public ReceptionEvent(string title, string description, DateTime date, DateTime time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string RsvpEmail => _rsvpEmail;

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}RSVP Email: {_rsvpEmail}\n";
    }

    public override string GetShortDescription()
    {
        return $"Type: Reception\nTitle: {Title}\nDate: {Date.ToShortDateString()}\n";
    }
}
