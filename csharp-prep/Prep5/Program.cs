using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string username = PromptUserName();
        int favorite = PromptUserNumber();
        int squared = SquareNumber(favorite);
        DisplayResult(username, squared);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your username: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favorite = int.Parse(Console.ReadLine());
            return favorite;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResult(string username, int squared)
        {
            Console.WriteLine($"{username}, the square of your number is {squared}.");
        }


        
    }
}