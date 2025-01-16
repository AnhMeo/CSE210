using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int total = 0;
        int average = 0;
        int greatest = 0;
        int length = 0;

        Console.Write("Enter a list of numbers, type 0 when finished: ");
        int response = int.Parse(Console.ReadLine());
        while (response != 0)
        {
            numbers.Add(response);
            total += response;

            if (response > greatest)
            {
                greatest = response;
            }
            Console.Write("Enter number: ");
            response = int.Parse(Console.ReadLine());
              
        }

        length = numbers.Count;
        average = total / length;

        Console.WriteLine($"The sum of the numbers is: {total}.");
        Console.WriteLine($"The average of all the numbers is: {average}.");
        Console.WriteLine($"The largest number is: {greatest}.");


    }
}   