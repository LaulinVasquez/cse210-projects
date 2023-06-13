using System;

public class rectangle :  Shape
{
    private double _length;
    private double _width;

    public rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _width * _length;
    }
}