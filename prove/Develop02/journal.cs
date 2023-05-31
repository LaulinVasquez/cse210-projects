using System;
using System.Collections.Generic;
using System.IO;

public class journal
{
    public List<string> _entryList = new List<string>(); 
    
    public string _fileName;
    
    public void addEntry(string entry)
    {
        _entryList.Add(entry);
    }

    public void SaveToFile(List<string> nameList)
    {
        Console.WriteLine($"information saved in {_fileName}\n");
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {   
            foreach(string line in nameList)
            {
                outputFile.WriteLine(line);
            }
        }
    }

    public void LoadFile(List<string> _entryList)
    {
        Console.WriteLine("Information loaded\n");
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach(string line in lines)
        {
            _entryList.Add(line);
        }
    }


}