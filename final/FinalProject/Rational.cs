using System.Diagnostics;

namespace LiveCoding
{
    public class Rational
    {
        int _numerator;
        int _denominator;

        public Rational(int numerator, int denominator)
        {
            _numerator = numerator;
            if (denominator == 0)
            {
                throw new ArgumentException(String.Format($"{denominator} is not a valid demoninator value."));
            }
            _denominator = denominator;
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }
    }
}