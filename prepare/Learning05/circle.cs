using System;

public class circle : Shape
{
    private double _radius;

    public circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}