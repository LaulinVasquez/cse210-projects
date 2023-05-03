using System;

class Program
{
    public class Car
    {
       public string _color = "this is a dark blue";
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox!");
        Car test = new Car();
        Console.WriteLine(test._color);
        
    }

}