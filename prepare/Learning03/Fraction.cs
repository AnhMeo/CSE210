public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int Number)
    {
        _numerator = Number;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public string GetFractionString()
    {
        string fractionForm = $"{_numerator}/{_denominator}";
        return fractionForm;
    }

    public double GetDecimalValue()
    {
        double decimalForm = (double)_numerator / (double)_denominator;
        return decimalForm;
    }
}