using System;

public class Simple : Completable
{

    public Simple(string savedString, bool isComplete) : base(savedString, isComplete)
    {

    }

    public override string Display()
    {
        string completion = (_isComplete == true) ? "[X]" : "[ ]";

        string displayGoal = $"{completion} {_name} ({getDescription()}) Points: {GetPoints()}";
        return displayGoal;
    }

    public override int Complete()
    {
        if (!_isComplete)
        {
            int i = GetPoints();
            _isComplete = true;
            return i;
        }
        return 0;
    }

    public override string SetGoalAttributes()
    {
        string line = $"Simple|{_name}~{getDescription()}~{GetPoints()}|{_isComplete}";
        return line;
    }
}