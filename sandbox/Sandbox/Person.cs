using System;
using System.Collections.Generic;

class Person
{
    private string _name;
    public List<string> _scripture;
    public string Name
    {
        // here you get the value of _name but in order to acces to the _name value you have to set some
        get{return _name;}
        set{_name = value;}
    }
    public void scripture()
    {
        _scripture = new List<string>();
    }
}