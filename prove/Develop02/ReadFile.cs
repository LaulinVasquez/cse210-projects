using System;
using System.Collections.Generic;


public class DisplayFile
{
    public string _file;

    public string _entry;
    public void ReadFromFile()
    {
        
        Console.WriteLine("File found succesfully\n");

        List<string> prompts = new List<string>();
        string[]  lines = System.IO.File.ReadAllLines(_file);

        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }

    }
}