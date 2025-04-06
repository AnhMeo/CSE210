using System;

public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string Speaker => _speaker;
    public int Capacity => _capacity;

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}Speaker: {_speaker}\nCapacity: {_capacity}\n";
    }

    public override string GetShortDescription()
    {
        return $"Type: Lecture\nTitle: {Title}\nDate: {Date.ToShortDateString()}\n";
    }
}
