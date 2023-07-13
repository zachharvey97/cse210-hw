using System;

class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        return ((_laps * 50) / 1000);
    }

    public override double Speed()
    {
        return Distance() / _duration * 60;
    }

    public override double Pace()
    {
        return _duration / Distance();
    }

    public override void Summary()
    {
        Console.WriteLine($"{_date:d} Swimming ({_duration} min): Distance {Distance():f1} km, Speed {Speed():f1} kph, Pace: {Pace():f1} min per km");
    }
}