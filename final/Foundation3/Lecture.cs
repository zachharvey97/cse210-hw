using System;

class Lecture:Events
{
    private string _speaker;
    private string _capacity;

    public Lecture(string title, string description, DateTime date, Address address, string speaker, string capacity) : base(title, description, date, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void FullDetailsDisplay()
    {
        base.StandardDisplay();
        Console.WriteLine($"Speaker: {_speaker} - Capacity: {_capacity}");
    }

    public void ShortDisplay()
    {
        string shortDetails = ShortDescription();
        Console.WriteLine($"Event: Lecture\n{shortDetails}");
    }
}