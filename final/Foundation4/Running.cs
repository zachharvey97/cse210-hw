using System;

class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        return _distance/_duration * 60;
    }

    public override double Pace()
    {
        return _duration / _distance;
    }

    public override void Summary()
    {
        Console.WriteLine($"{_date:d} Running ({_duration} min): Distance {Distance():f1} km, Speed {Speed():f1} kph, Pace: {Pace():f1} min per km");
    }
}