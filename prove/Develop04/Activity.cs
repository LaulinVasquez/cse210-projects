using System;
// Base clase
public class Activity
{
    private string _activityName;
    private string _description;
    protected int _activityDuration;
    protected DateTime  _time;
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;    
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetActivityDuration()
    {
        return _activityDuration;
    }    
    public void DisplayIntro()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}. \n");
        Console.WriteLine($"{_description}\n");
    }
    public void PauseShowSpinner(int num = 7)
    {
        List<string> animation = new List<string>();
        int i = 0;
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(num);
        
        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
        }
        Console.WriteLine("");
    }
    public void PauseShowCountdown(int num = 0)
    {
        for (int i= num; i >0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
    }
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseShowSpinner();
    }
    public void BeginActivity()
    {
        Console.Write("You may begin in: ");
        PauseShowCountdown(5);
    }   
    //  These 3 methods contains previous methods 
    public void StartMessage()
    {
        DisplayIntro();
        Console.Write("How long, in seconds, would you like for your session ? ");
        _activityDuration =  Convert.ToInt32(Console.ReadLine());
        GetReady();
    }
    public DateTime DurationInSeconds()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);
        _time = endTime;
        return _time;
    }
    public void EndingMessage()
    {
        Console.WriteLine("\nWell Done!!");
        PauseShowSpinner();
        Console.WriteLine($"you have completed {_activityDuration} seconds of the {_activityName}.");
        PauseShowSpinner();
        Console.Clear();
    }
}   