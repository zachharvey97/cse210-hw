using System;

class Reception:Events
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, Address address, string rsvp) : base(title, description, date, address)
    {
        _rsvpEmail = rsvp;
    }

    public void FullDetailsDisplay()
    {
        base.StandardDisplay();
        Console.WriteLine($"RSVP: {_rsvpEmail}");
    }

    public void ShortDisplay()
    {
        string shortDetails = ShortDescription();
        Console.WriteLine($"Event: Reception\n{shortDetails}");
    }
}