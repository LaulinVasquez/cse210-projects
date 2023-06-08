using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private string _prompt;
    private int _listingCount;

    public ListingActivity(string activityName, string description) : base(activityName,description)
    {
        // not information needed
    }

    public string GetRandomPrompt()
    {
        List<string> promptList = new List<string>();
        promptList.Add("Who are people that you appreciate?");
        promptList.Add("What are personal strengths of yours?");
        promptList.Add("Who are people that you have helped this week?");
        promptList.Add("When have you felt the Holy Ghost this month?");
        promptList.Add("Who are some of your personal heroes?");

        Random R = new Random();
        int index = R.Next(promptList.Count);
        // set the value for the your attribute
        _prompt = promptList[index]; 

        return _prompt;
    }
    public void ShowPrompt()
    {
        GetReady();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        BeginActivity();
    }

    public void ListingAndSummary()
    {
        List<string>items = new List<string>();
        DateTime t = DurationInSeconds();
        do
        {
            Console.Write("> ");
            string user = Console.ReadLine();
            items.Add(user);
        }
        while (DateTime.Now < t);
        _listingCount = items.Count;
        Console.WriteLine($"You listed {_listingCount} items!");
    }
    public void DisplayLisingActivity()
    {
        StartMessage();
        ShowPrompt();
        ListingAndSummary();
        EndingMessage();
    }
}