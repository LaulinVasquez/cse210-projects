using System;
using System.Collections.Generic;
using System.IO;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }    
    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();   
    
    public void SaveObject(List<Shape> shapes)
    {
        using (StreamWriter outputFile = new StreamWriter("shape.txt"))
        {
            int listt = 0;
            foreach(Shape x in shapes)
            {
                listt++;
                outputFile.WriteLine($"{listt}. {x}: {x.GetColor()}, length: {x.GetArea()}");
            }
        }
    }
    public void DisplayFile()
    {
        string[] lines = System.IO.File.ReadAllLines("Shape.txt");
        foreach(string line in lines)
        {
            string[] separator = line.Split(":");

            foreach(string s in separator)
            {
                Console.WriteLine(s);
            }
        }


    }
}