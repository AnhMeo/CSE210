using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction No1 = new Fraction();
        Console.WriteLine(No1.GetFractionString());
        Console.WriteLine(No1.GetDecimalValue());

        Fraction No2 = new Fraction(5);
        Console.WriteLine(No2.GetFractionString());
        Console.WriteLine(No2.GetDecimalValue());

       Fraction No3 = new Fraction(3,4);
       Console.WriteLine(No3.GetFractionString()); 
       Console.WriteLine(No3.GetDecimalValue());

       Fraction No4 = new Fraction(1,3);
       Console.WriteLine(No4.GetFractionString());
       Console.WriteLine(No4.GetDecimalValue());
    }
}