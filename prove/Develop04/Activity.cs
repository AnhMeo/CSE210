using System;
using System.Threading;

class Activity
{
    protected int duration;

    public Activity(int duration)
    {
        this.duration = duration;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowAnimation(3); // A short pause before starting
    }

    public void End(string activityName)
    {
        Console.WriteLine("Well done!");
        ShowAnimation(3);
        Console.WriteLine($"You have completed the {activityName} activity for {duration} seconds.");
        ShowAnimation(3);
    }

    protected void ShowAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
