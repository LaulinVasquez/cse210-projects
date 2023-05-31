using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
    // new variables that contains the methods used in this program
    Entry entry = new Entry();
    journal Journal = new journal();
    
    string user = "";

    do
    {
        // Set date Time to the Entry Class
        DateTime date = DateTime.Now;
        entry._dateTime = date.ToString("dddd, dd MMMM yyyy - hh:mm tt");

        // Display Menu
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine($"1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
        
        user = Console.ReadLine();
       
        if (user == "write" || user == "1")
        {
            entry.displayPrompts();
            entry._Entry = Console.ReadLine();

            //  User entry with prompt will be save with this function
            Journal.addEntry(entry.entry());
        }
        if (user == "display" || user == "2")
        {
        //   you can check if your journal was loaded or not, the message below will pop ups to inform
            if (Journal._entryList.Count() == 0)
            {   
                Console.WriteLine("Sorry but your journal is empty, load your journal\n ");
            }
            else
            {
                foreach(string line in Journal._entryList)
                {
                    Console.WriteLine(line);
                }
            }
        }
        if (user == "load" || user == "3")
        { 

          Console.Write("Enter file name: ");
          Journal._fileName= Console.ReadLine();
          Journal.LoadFile(Journal._entryList);

        }
        if (user == "save" || user == "4")
        {
            // Save user entries into the journal file 
            Console.Write("what's the name of the file? ");
            Journal._fileName = Console.ReadLine(); 
            Journal.SaveToFile(Journal._entryList);

        }        
    }
    while (user != "5");
    Console.WriteLine("Journal Closed");
    }
}