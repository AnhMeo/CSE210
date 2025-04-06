using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create instances of different activities
        var activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),  // 3 miles in 30 minutes
            new Cycling("03 Nov 2022", 30, 12.0), // 12 km/h for 30 minutes
            new Swimming("03 Nov 2022", 30, 20)   // 20 laps in 30 minutes
        };

        // Iterate through the list of activities and display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
