using System;

public class BreathingActivity : Activity
{
    private string _breathIn;
    private string _breathOut;

    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {
        // Set the Breath in and breath as default here
        _breathIn = "breath in...";
        _breathOut = "Now breath out...";
    }
    
    public void DisplayBreathingActivity()
    {
        StartMessage();
        DateTime t = DurationInSeconds();
        while (DateTime.Now < t)
        {
            
            Console.Write($"\n{_breathIn}");
            PauseShowCountdown(4);
            Console.Write(_breathOut);
            PauseShowCountdown(6);

        }
        EndingMessage();    
    }
}