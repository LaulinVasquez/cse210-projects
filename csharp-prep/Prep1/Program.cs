using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();

        Console.Write("What is your Last name: ");
        string last_name = Console.ReadLine();
        
        Console.WriteLine($"Your name is: {name} {last_name}");
    }
}