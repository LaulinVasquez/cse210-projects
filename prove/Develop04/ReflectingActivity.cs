using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private string _prompt;
    private string _question;
    public ReflectingActivity(string activityName, string description) : base (activityName, description)
    {
    }
    public string GetRandomPrompt()
    {
        List<string> promptList = new List<string>();
        promptList.Add("Think of a time when you stood up for someone else.");
        promptList.Add("Think of a time when you did something really difficult.");
        promptList.Add("Think of a time when you helped someone in need.");
        promptList.Add("Think of a time when you did something truly selfless.");
        
        Random R = new Random();
        int index = R.Next(promptList.Count);
        // set the value for the prompt attribute
        _prompt = promptList[index];

        return _prompt;
    }
    public string GetRandomQuestion()
    {
        List<string> quetionList = new List<string>();
        quetionList.Add("> Why was this experience meaningful to you?");
        quetionList.Add("> Have you ever done anything like this before?");
        quetionList.Add("> How did you get started?");
        quetionList.Add("> How did you feel when it was complete?");
        quetionList.Add("> What made this time different than other times when you were not as successful?");
        quetionList.Add("> What is your favorite thing about this experience?");
        quetionList.Add("> What could you learn from this experience that applies to other situations?");
        quetionList.Add("> What did you learn about yourself through this experience?");
        quetionList.Add("> How can you keep this experience in mind in the future?");

        Random R = new Random();
        int index = R.Next(quetionList.Count);
        _question = quetionList[index]; 

        return _question;       
    }
    public void DisplayRandoPrompt()
    {
        string user = "";
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"---{GetRandomPrompt()}---\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        do
        {
            user = Console.ReadLine();
            if (user != "")
            {
                Console.WriteLine($"ops! you typed:'{user}', try again!");
            }      
        }
        while (user != "");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience."); 
        BeginActivity();
        Console.Clear();

    }
    public void DisplayReflectingActivity()
    {
        StartMessage();
        DisplayRandoPrompt();
        DateTime t = DurationInSeconds();
        
        while (DateTime.Now < t)
        {
            Console.Write($"{GetRandomQuestion()} ");
            PauseShowSpinner(7);
        }
        EndingMessage();
    }
}