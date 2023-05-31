using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
    // new variables that contains the methods used in this program
    Load loadFile = new Load();
    Entry entry = new Entry();
    saveFile save = new saveFile();
    journal Journal = new journal();
    
    string user = "";

    while (user != "5")
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
            // Display prompts from Entry class
            entry.displayPrompts();
            entry._Entry = Console.ReadLine();
            //  User entry with prompt will be save with this function
            entry.entry();
        }
        if (user == "display" || user == "2")
        {
        //   you can check if your journal was loaded or not, the message below will pop ups to inform
            if (entry._entryList.Count == 0)
            {
                Console.WriteLine("Sorry but your journal is empty, did you load your journal?");
            }
            else
            {
                foreach(string line in entry._entryList)
                {
                    Console.WriteLine(line);
                }
            }
        }
        if (user == "load" || user == "3")
        { 
          Console.Write("Enter file name: ");
          loadFile._fileReference = Console.ReadLine();
          loadFile.LoadFile(entry._entryList);
        }
        if (user == "save" || user == "4")
        {
            // Save user entries into the journal file 
            Console.Write("what's the name of the file? ");
            save._fileName = Console.ReadLine();
            
            // this method below will execute the function in the saver class to push the information added in the promptList to the file
            save.SaveToFile(entry._entryList);
        }        
    }
    Console.WriteLine("Journal Closed");
    }
}