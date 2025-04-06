using System;

public abstract class Activity
{
    // Private fields for the common attributes
    private string _date;
    private double _minutes;

    // Constructor to initialize shared properties
    public Activity(string date, double minutes)
    {
        this._date = date;
        this._minutes = minutes;
    }

    // Protected properties to access the private fields
    public string Date => _date;
    public double Minutes => _minutes;

    // Abstract methods for subclasses to implement
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to generate the summary
    public virtual string GetSummary()
    {
        return $"{Date} {GetType().Name} ({Minutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
