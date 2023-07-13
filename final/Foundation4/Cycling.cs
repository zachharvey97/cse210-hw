using System;

class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return _speed * _duration / 60;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60 / _speed;
    }

    public override void Summary()
    {
        Console.WriteLine($"{_date:d} Cycling ({_duration} min): Distance {Distance():f1} km, Speed {Speed():f1} kph, Pace: {Pace():f1} min per km");
    }
}