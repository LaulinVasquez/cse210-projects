using System;

public class EternalGoal : Goal
{

    public override string  CreateGoal()
    {
        return $"{GetGoal()},{GetDescription()},{GetPoints()}";
    }
    public override string GetStringRepresentation()
    {
        return $"{GetGoal()} ({GetDescription()})";
    }
    // every time you call this override method will get the points previously set
    public override int RecordEvent()
    {
        return GetPoints();
    }
}