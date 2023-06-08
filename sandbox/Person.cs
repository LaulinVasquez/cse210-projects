using System;
using System.Collections.Generic;

public class Person
{
    protected string _name;
    protected string _lastName;

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetLastName()
    {
        return _lastName;
    }

    public void SetLastName(string lastName)
    {
        _lastName = lastName;
    }

    public string GetId()
    {
        return $"{_name} {_lastName}";
    }

}