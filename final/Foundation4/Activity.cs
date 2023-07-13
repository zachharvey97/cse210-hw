using System;

public abstract class Activity
{
    public DateTime _date {get; private set;}
    public int _duration {get; private set;}

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();

    public abstract void Summary();
}