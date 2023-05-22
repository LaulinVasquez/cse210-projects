using System;
using System.Collections.Generic;
using System.IO;
public class saveFile
{
    public string _fileName;
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
}