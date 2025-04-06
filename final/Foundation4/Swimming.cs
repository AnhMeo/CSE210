using System;

public class Swimming : Activity
{
    private int _laps; // Number of laps swum

    // Constructor for swimming activity
    public Swimming(string date, double minutes, int laps) : base(date, minutes)
    {
        this._laps = laps;
    }

    // Override GetDistance method
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62; // Distance in miles
    }

    // Override GetSpeed method
    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60; // Speed in miles per hour
    }

    // Override GetPace method
    public override double GetPace()
    {
        return Minutes / GetDistance(); // Pace in minutes per mile
    }

    // Override GetSummary method for swimming
    public override string GetSummary()
    {
        return $"{Date} Swimming ({Minutes} min): Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
