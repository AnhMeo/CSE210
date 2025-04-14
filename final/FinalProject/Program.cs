using System;
using LiveCoding;

class Program
{
    static void Main(string[] args)
    {
        List<Complex> ComplexNumbers = new List<Complex>
        {
            new Complex(1,2),
            new Complex(99,100),
            new Complex(15,5),
            new Complex(12,11)
        };

        ComplexNumbers.Sort(ComplexSorting.CompareComplexNumbers);
        foreach (Complex num in ComplexNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("New test type below");

        List<Rpsls.Hand> hands1 = new() { Rpsls.Hand.Rock, Rpsls.Hand.Paper };
        Console.WriteLine("--- Rock vs Paper ---");
        foreach (var hand in RpslsSorting.SortHands(hands1))
            Console.WriteLine(hand);

        

    }
}