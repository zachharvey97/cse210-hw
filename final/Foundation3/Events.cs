using System;

class Events
{
    private string _title;
    private string _description;
    private DateTime _date;
    private Address _address;

    public Events(string title, string description, DateTime date, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
    }

    public void StandardDisplay()
    {
        Console.WriteLine($"{_title} - {_description}");
        Console.WriteLine($"Date: {_date.ToShortDateString()}\nTime: {_date.ToShortTimeString()}\nAddress: {_address.GetAddress()}");
    }

    public string ShortDescription()
    {
        return $"Title: {_title}\nDate: {_date.ToShortDateString()}";
    }
}