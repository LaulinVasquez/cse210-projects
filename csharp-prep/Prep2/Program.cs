using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade porcentage: ");
        int porcentage = Convert.ToInt32(Console.ReadLine());
        
        string letter = "";

        if (porcentage >= 90)
        {
            letter = "A";
        }
        else if (porcentage >= 80)
        {
            letter = "B";
        }
        else if (porcentage >= 70)
        {
            letter = "C";
        }
        else if (porcentage >= 60)
        {
            letter = "D";
        }
        else if (porcentage < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (porcentage >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("Sorry but you can try it next time!");
        }
    }
}