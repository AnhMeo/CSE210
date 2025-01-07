using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int number = int.Parse(Console.ReadLine());
        
        string letter = "";
        string sign = "";

        // Getting letter grades
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Getting the + or - signs for letter grades
        int lastDigit = number % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        //Making sure there's no A+, F+, or F-
        if (letter == "A" && sign == "+")
        {
            sign = ""; 
        }
        if (letter == "F")
        {
            sign = "";
        }

        //Printing letter grade and sign
        Console.WriteLine($"Your grade is {letter}{sign}.");


        //Printing pass (or not pass) message!
        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {
            Console.WriteLine("You did not pass. Don't give up! Good luck next time.");
        }
        

    }
}