using System;

 class Address
{
    private string _street { get; set; }
    private string _city { get; set; }
    private string _state { get; set; }
    public string _country { get; private set; }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public Boolean IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void printAddress()
    {
        Console.WriteLine($"{_street}\n{_city}, {_state}\n{_country}");
    }
}