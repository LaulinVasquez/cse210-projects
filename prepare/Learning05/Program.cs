using System;

class Program
{
    static void Main(string[] args)
    {
        square s = new square("Red", 8);
        circle c = new circle("Blue", 6);
        rectangle r = new rectangle("Yellow", 5,10);
        
        List<Shape> figures = new List<Shape>();
        figures.Add(s);
        figures.Add(c);
        figures.Add(r);
        
        // foreach(Shape figure in figures)
        // {
        //     figure.DisplayFile();
        // }

        s.DisplayFile();
    }
}