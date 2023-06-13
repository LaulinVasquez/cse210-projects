using System;

class Program
{
    static void Main(string[] args)
    {
        square s = new square("red", 8);
        circle c = new circle("blue", 6);
        rectangle r = new rectangle("yellow", 5,10);

        List<Shape> figures = new List<Shape>();
        figures.Add(s);
        figures.Add(c);
        figures.Add(r);

        foreach(Shape figure in figures)
        {
            Console.WriteLine($"Color: {figure.GetColor()}, length: {figure.GetArea()}");
        }

    }
}