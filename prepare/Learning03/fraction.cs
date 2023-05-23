using System;

public class Fraction
{
    private int _top;
    private int _bottom;

// This are constructor that makes the work automatically and all of them has the same name as the Fraction class
    public Fraction()
    {
        _top = 1;
        _bottom = 1;     
    }
    public Fraction(int num1)
    {
        _top = num1;
        _bottom = 1;
    }
    public Fraction(int num1, int num2)
    {
        _top = num1;
        _bottom = num2;
    }
// Methods that returns value!
    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }

}