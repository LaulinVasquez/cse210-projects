using System;

public class journal
{
    public List<string> _entryList = new List<string>(); 

    
    public  void saveTojournal(string entry){
        _entryList.Add(entry);
    }


}