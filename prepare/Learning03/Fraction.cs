using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    public void SetNumerator(int n)
    {
        _numerator = n;
    }
    public void SetDenominator(int n)
    {
        _denominator = n;
    }
    public int GetNumerator()
    {
        return _numerator;
    }
    public int GetDenominator()
    {
        return _denominator;
    }
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public double GetDecimalValue()
    {
        double calculation = (double) _numerator/_denominator;
        return calculation;
    }
}