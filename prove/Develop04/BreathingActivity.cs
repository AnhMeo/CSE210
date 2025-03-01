using System;
using System.Threading;

class BreathingActivity : Activity
{
    private const int BarWidth = 20; // Total width of the bar

    public BreathingActivity(int duration) : base(duration) { }

    public void RunActivity()
    {
        Start();
        Console.WriteLine("This activity will help you relax by guiding you through deep breathing.");
        Console.WriteLine("Clear your mind and focus on your breathing.\n");

        int elapsedTime = 0;
        while (elapsedTime < duration)
        {
            ShowBreathingBar(true, 3);  // Inhale
            elapsedTime += 3;

            ShowBreathingBar(false, 3); // Exhale
            elapsedTime += 3;
        }

        Console.WriteLine(); // Ensure cursor returns to a new line after animation
        End("Breathing");
    }

    private void ShowBreathingBar(bool inhaling, int seconds)
    {
        int halfWidth = BarWidth / 2;
        int steps = halfWidth; // Number of animation steps
        int delay = (seconds * 1000) / steps; // Time per step

        for (int i = 0; i <= steps; i++)
        {
            int fill = inhaling ? i : (steps - i);
            //breathing bar that fills from the inside out, and empties from the outside in. Looks cool! 
            string bar = new string(' ', halfWidth - fill) + new string('█', fill * 2) + new string(' ', halfWidth - fill);
            // learned that we can reuse the same line by using \r instead of having to clear the terminal each time
            Console.Write($"\rBreathe {(inhaling ? "In" : "Out")}  [{bar}] ");
            Thread.Sleep(delay);
        }
    }
}
