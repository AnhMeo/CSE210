using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

public class ComplexSorting
{
    public static List<LiveCoding.Complex> Sort(List <LiveCoding.Complex> complexNumbers)
    {
        complexNumbers.Sort(CompareComplexNumbers);
        return complexNumbers;
    }

    public static int CompareComplexNumbers(LiveCoding.Complex a, LiveCoding.Complex b)
    {
        double aModulus = a.Modulus();
        double bModulus = b.Modulus();

        if (aModulus < bModulus)
            return -1;
        if (aModulus > bModulus)
            return 1;
        else
            return 0;
    } 

}