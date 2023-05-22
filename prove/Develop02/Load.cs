using System;

public class Load
{
    public string _fileReference;
    public void LoadFile(List<string> _entryList)
    {
        Console.WriteLine("Information loaded\n");
        string[] lines = System.IO.File.ReadAllLines(_fileReference);

        foreach(string line in lines)
        {
            _entryList.Add(line);
        }
    }
}