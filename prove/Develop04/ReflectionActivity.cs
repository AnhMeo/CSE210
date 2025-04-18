using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration) : base(duration) { }

    public void RunActivity()
    {
        Start();
        Console.WriteLine("This activity will help you reflect on times when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.\n");

        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("Take a moment to reflect...");
        ShowSpinner(5);

        int elapsedTime = 0;
        while (elapsedTime < duration)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowSpinner(5);
            elapsedTime += 5;
        }

        End("Reflection");
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return questions[rand.Next(questions.Count)];
    }

    private void ShowSpinner(int seconds)
    {
        // little loading spinner!!!
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 2; i++)
        {
            // borrowed the \r trick from BreathingActivity instead of just backspacing and reprinting. 
            Console.Write("\r" + spinner[i % 4] + " ");
            Thread.Sleep(500);
        }
    }
}
