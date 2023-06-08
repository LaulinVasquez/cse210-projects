using System;

class Program
{
    static void Main(string[] args)
    {
        string user = "";
        List<string> menu = new List<string>();
        menu.Add("Menu options:");
        menu.Add("  1. Start breathing activity");
        menu.Add("  2. Start reflecting activity");
        menu.Add("  3. Start listing activity");
        menu.Add("  4. Quit");
        menu.Add("Select a choice from the menu:");
        
        do
        {
            foreach(string option in menu)
            {
                Console.WriteLine(option);
            }
            user = Console.ReadLine();

            if( user == "1")
            {
                BreathingActivity Breathing = new BreathingActivity("breathing Activity", "Smile, breathe, and take it slow. Doing this will help you to relax.");
                Breathing.DisplayBreathingActivity();
                   
            }
            else if(user == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting activity", "This activity helps you look back on times in your life when you've shown strength and resilience.\nIt enables you to recognize your own power and how you can apply it in different areas of your life.");
                reflecting.DisplayReflectingActivity();

            }
            else if(user == "3")
            {
                ListingActivity listening = new ListingActivity("Listing activity", "This activity will have you make a list that will help you remember and ponder good moments\nin your life so that you may continue to have meaning and purpose in your own journey.");
                listening.DisplayLisingActivity();
            }

        }
        while(user != "4");
        Console.Clear();
        Console.WriteLine("Thank you for your time!");
    }
}