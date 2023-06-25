using System;

public class Eternal : Goals
{
    public Eternal(string savedString) : base(savedString)
    {
        
    }
    public override string Display()
    {
        string displayGoal = $"[ ] {_name} ({getDescription()}) Points: {GetPoints()}";
        return displayGoal;
    }
    public override int Complete()
    {
        int points = GetPoints();
        return points;
    }

    public override string SetGoalAttributes()
    {
        string line = $"Eternal|{_name}~{getDescription()}~{GetPoints()}";
        return line;
    }
}