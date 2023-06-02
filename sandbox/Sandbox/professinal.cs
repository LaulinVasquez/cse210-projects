using System;

public class Professional : Person
{
    private string _profession;

    private int _time;

    public string GetProfession()
    {
        return _profession;
    }

    public void SetProfession(string profession)
    {
        _profession = profession;
    }

    public void SetTime(int experienceTime)
    {
        _time = experienceTime;
    }

    public int GetTime()
    {
        return _time;
    }
    
    public string GetBio()
    {
        return $"\nname:{_name} {_lastName}\nprofession: {_profession}\nyears of experienced: {_time}";
    }
}