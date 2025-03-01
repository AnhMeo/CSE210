using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration) { }

    public void RunActivity()
    {
        Start();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You will have a few seconds to prepare...");
        ShowCountdown(5);
        
        Console.WriteLine("Start listing items:");
        List<string> responses = GetUserResponses();

        Console.WriteLine($"You listed {responses.Count} items!");
        End("Listing");
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }

    private List<string> GetUserResponses()
    {
        List<string> responses = new List<string>();
        int elapsedTime = 0;
        DateTime startTime = DateTime.Now;

        while (elapsedTime < duration)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
            elapsedTime = (int)(DateTime.Now - startTime).TotalSeconds;
        }

        return responses;
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}... ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
