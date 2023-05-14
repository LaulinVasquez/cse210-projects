using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
    // new variables that contains the methods used in this program
    Load loadFile = new Load();
    Entry prompts = new Entry();
    saveFile promptSaver = new saveFile();
    // promptList will record all user inputs and prompts so it can be save into the file later on.
    List<string> entryList = new List<string>();
    // create user variable to use while loop
    string user = "";

    while (user != "quit")
    {
        DateTime date = DateTime.Now;
        // date is really important, but
        prompts._dateTime = date.ToString("dddd, dd MMMM yyyy - hh:mm tt");

        // Display Menu
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine($"1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
        user = Console.ReadLine();
       
        if (user == "write" || user == "1")
        {
            prompts.displayPrompts();
            prompts._Entry = Console.ReadLine();
            // Save the prompt with the date into the List and the user answer to the List
            entryList.Add($"Date: {prompts._dateTime} Prompt: {prompts._randomPrompt}");
            entryList.Add($"{prompts._Entry}\n");
        }
        if (user == "display" || user == "2")
        {
        //   you can check if your journal was loaded or not, the message below will pop ups to inform
            if (entryList.Count == 0)
            {
                Console.WriteLine("Sorry but your journal is empty, did you load your journal?");
            }
            else
            {
                foreach(string line in entryList)
                {
                    Console.WriteLine(line);
                }
            }
        }
        if (user == "load" || user == "3")
        { 
          Console.Write("Enter file name: ");
          loadFile._fileReference = Console.ReadLine();
          loadFile.LoadFile(entryList);
        }
        if (user == "save" || user == "4")
        {
            // Save user inputs into the journal
            Console.Write("what's the name of the file? ");
            string userRespond = Console.ReadLine();
            promptSaver._fileName = userRespond;
            // this method below will execute the function in the saver class to push the information added in the promptList to the file
            promptSaver.SaveToFile(entryList);
        }        
    }

    }
}