using System;

public class Running : Activity
{
    private double _distance; // Distance in miles

    // Constructor for running activity
    public Running(string date, double minutes, double distance) : base(date, minutes)
    {
        this._distance = distance;
    }

    // Override GetDistance method
    public override double GetDistance()
    {
        return _distance; // Returns the stored distance directly
    }

    // Override GetSpeed method
    public override double GetSpeed()
    {
        return (_distance / Minutes) * 60; // Speed in miles per hour
    }

    // Override GetPace method
    public override double GetPace()
    {
        return Minutes / _distance; // Pace in minutes per mile
    }

    // Override GetSummary method for running
    public override string GetSummary()
    {
        return $"{Date} Running ({Minutes} min): Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
