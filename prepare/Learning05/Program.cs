using System;

class Program
{
    static void Main(string[] args)
    {
        string user = "";
        Console.WriteLine("Add something into a list:");
        List<string>item = new List<string>();
        do
        {
            Console.Write("> ");
            user = Console.ReadLine();
            item.Add(user);

        }
        while (user != "stop");
        Console.WriteLine($"You listed {item.Count} items");
    }
}