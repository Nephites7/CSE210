using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int top)
    {
        numerator = top;
        denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        numerator = top;
        denominator = bottom;
    }

    public int GetNumerator()
    {
        return numerator;
    }

    public int GetDenominator()
    {
        return denominator;
    }

    public void SetNumerator(int top)
    {
        numerator = top;
    }

    public void SetDenominator(int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        denominator = bottom;
    }

    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}

class Program
{
    static void Main()
    {
        Fraction fraction1 = new Fraction();       // Initializes to 1/1
        Fraction fraction2 = new Fraction(5);      // Initializes to 5/1
        Fraction fraction3 = new Fraction(3, 4);   // Initializes to 3/4
        Fraction fraction4 = new Fraction(1, 3);   // Initializes to 1/3

        fraction1.SetNumerator(2);
        fraction1.SetDenominator(3);
        int numerator1 = fraction1.GetNumerator();
        int denominator1 = fraction1.GetDenominator();

        string fractionString = fraction2.GetFractionString();
        double decimalValue = fraction2.GetDecimalValue();

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(numerator1);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(denominator1);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(decimalValue);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
    }
}
