using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();
        Fraction second = new Fraction(3);
        Fraction third = new Fraction(3,4);

        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());
        
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());
        
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());
        
    }
}