using System;

class Outdoor:Events
{
    private string _weather;

    public Outdoor(string title, string description, DateTime date, Address address, string weather) : base(title, description, date, address)
    {
        _weather = weather;
    }

    public void FullDetailsDisplay()
    {
        base.StandardDisplay();
        Console.WriteLine($"Weather: {_weather}");
    }

    public void ShortDisplay()
    {
        string shortDetails = ShortDescription();
        Console.WriteLine($"Event: Outdoor Gathering\n{shortDetails}");
    }
}