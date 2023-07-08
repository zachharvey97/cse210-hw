using System;

class Customer
{
    public string _name { get; private set; }
    public Address _address { get; private set; }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public Boolean IsInUSA()
    {
       Boolean USA = _address.IsInUSA();
       return USA;
    }
}
