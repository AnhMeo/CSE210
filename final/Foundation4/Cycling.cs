using System;

public class Cycling : Activity
{
    private double _speed; // Speed in km/h

    // Constructor for cycling activity
    public Cycling(string date, double minutes, double speed) : base(date, minutes)
    {
        this._speed = speed;
    }

    // Override GetDistance method
    public override double GetDistance()
    {
        return (_speed * Minutes) / 60; // Distance in kilometers
    }

    // Override GetSpeed method
    public override double GetSpeed()
    {
        return _speed; // Returns the stored speed directly
    }

    // Override GetPace method
    public override double GetPace()
    {
        return 60 / _speed; // Pace in minutes per kilometer
    }

    // Override GetSummary method for cycling
    public override string GetSummary()
    {
        return $"{Date} Cycling ({Minutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
