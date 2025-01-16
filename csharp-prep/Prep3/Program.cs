using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        int guesses = 0;

        Console.Write("What is your guess? ");
        int response = int.Parse(Console.ReadLine());
        guesses += 1;

        while (number != response)
        {
            if (number > response)
            {
            Console.WriteLine("Too low! Guess higher");
            }
            else
            {
            Console.WriteLine("Too high! Guess lower");
            }
            Console.Write("What is your guess? ");
            response = int.Parse(Console.ReadLine());
            guesses += 1;
        }
        
        Console.WriteLine($"Congratulations! You guessed correctly in {guesses} tries!");
        



    }
}