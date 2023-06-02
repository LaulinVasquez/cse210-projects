using System;

class Program
{
    static void Main(string[] args)
    {
        string user = "";
        List<string> menu = new List<string>();
        menu.Add("  1. Start breathing activity");
        menu.Add("  2. Start reflecting activity");
        menu.Add("  3. Start listing activity");
        menu.Add("  4. Quit");

        do
        {
            Console.WriteLine("Menu options: ");
            foreach(string option in menu)
            {
                Console.WriteLine(option);
            }
            Console.Write("Select a choice from the menu: ");
            user = Console.ReadLine();
        }
        while(user != "quit");
    }
}