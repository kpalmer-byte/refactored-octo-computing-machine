using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string StreetAddress
    {
        get { return _streetAddress; }
        private set { _streetAddress = value; } 
    }

    public string City
    {
        get { return _city; }
        private set { _city = value; }
    }

    public string State
    {
        get { return _state; }
        private set { _state = value; }
    }

    public string Country
    {
        get { return _country; }
        private set { _country = value; }
    }

    public bool InUSA()
    {
        return Country == "USA";
    }

    public string FullAddress()
    {
        return $"{StreetAddress}\n{City}\n{State}\n{Country}";
    }

}