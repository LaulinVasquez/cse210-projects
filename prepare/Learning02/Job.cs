using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _StartYear;
    public int _EndYear;
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_company} ({_jobTitle}) {_StartYear}-{_EndYear}");
    }
}