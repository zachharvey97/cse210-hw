using System;

public class Checklist : Completable
{
    private int _bonus;
    private int _timesCompleted;
    private int _timesToComplete;
    public Checklist(string savedString, bool isComplete, int bonus, int completed, int toComplete) : base(savedString, isComplete)
    {
        _bonus = bonus;
        _timesCompleted = completed;
        _timesToComplete = toComplete;
    }

    public override string Display()
    {
        string completion = (_isComplete == true) ? "[X]" : "[ ]";

        string displayGoal = $"{completion} {_name} ({getDescription()}) Points: {GetPoints()} --- ({_timesCompleted}/{_timesToComplete})";
        return displayGoal;
    }

    public override int Complete()
    {
        if (!_isComplete)
        {
            int i = GetPoints();
            _timesCompleted ++;
            if (_timesCompleted == _timesToComplete)
            {
                _isComplete = true;
                i += _bonus;
            }
            return i;
        }
        return 0;
    }

    public override string SetGoalAttributes()
    {
        string line = $"Checklist|{_name}~{getDescription()}~{GetPoints()}|{_isComplete}|{_bonus}|{_timesCompleted}|{_timesToComplete}";
        return line;
    }
}