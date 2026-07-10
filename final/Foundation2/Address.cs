class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
        _city = " ";
        _country = " ";
        _state = "";
        _streetAddress = " ";
    }

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public void SetStreet(string street)
    {
        _streetAddress = street;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public void SetState(string state)
    {
        _state = state;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }

    public bool IfUSA()
    {
        if (_country == "USA" || _country == "United States of America")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string StringLine()
    {
        return $"{_streetAddress} {_city} {_state} {_country}";
    }
}