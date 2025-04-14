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

        //
        List<Rpsls.Hand> hands1 = new() { Rpsls.Hand.Rock, Rpsls.Hand.Paper };
        Console.WriteLine("--- Rock vs Paper ---");
        foreach (Rpsls.Hand hand in RpslsSorting.SortHands(hands1))
            Console.WriteLine(hand);

        List<Rpsls.Hand> hands2 = new() { Rpsls.Hand.Rock, Rpsls.Hand.Paper, Rpsls.Hand.Scissors };
        Console.WriteLine("--- Rock vs Paper vs Scissors---");
        foreach (Rpsls.Hand hand in RpslsSorting.SortHands(hands2))
            Console.WriteLine(hand);

        List<Rpsls.Hand> hands3 = new() { Rpsls.Hand.Scissors, Rpsls.Hand.Paper, Rpsls.Hand.Rock };
        Console.WriteLine("--- Scissors vs Paper vs Rock ---");
        foreach (Rpsls.Hand hand in RpslsSorting.SortHands(hands3))
            Console.WriteLine(hand);
        //please work
        List<Rpsls.Hand> hands4 = new() { Rpsls.Hand.Spock, Rpsls.Hand.Lizard, Rpsls.Hand.Paper };
        Console.WriteLine("--- Spock vs Lizard vs Paper ---");
        foreach (Rpsls.Hand hand in RpslsSorting.SortHands(hands4))
            Console.WriteLine(hand);
        //YES!!!!
        
    }
}