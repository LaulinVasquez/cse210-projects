using System;
using System.IO;
using System.Collections.Generic;
public class Entry
{
    public List<string> _promptGenerator = new List<string>();  
    public List<string> _entryList = new List<string>(); 
    public string _randomPrompt;
    public string _dateTime;
    public string _Entry;  
    public void displayPrompts()
    {
       _promptGenerator.Add("Who was the most interesting person I interacted with today?");
       _promptGenerator.Add("What was the best part of my day?");
       _promptGenerator.Add("How did I see the hand of the Lord in my life today? ");
       _promptGenerator.Add("what made you feel angry?");
       _promptGenerator.Add("What made you feel happy toady?");

        Random R = new Random();
        int _index = R.Next(_promptGenerator.Count);
        // this will give acces 
        _randomPrompt = _promptGenerator[_index];
        Console.WriteLine(_promptGenerator[_index]);
    }
    public void journal(){
        _entryList.Add($"Date {_dateTime} Prompt: {_randomPrompt}");
        _entryList.Add($"{_Entry}\n");
    }
}