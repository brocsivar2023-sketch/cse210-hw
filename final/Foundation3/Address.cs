class Address
{
    private string _street;
    private string _town;
    private string _state;
    private string _country;

    public Address()
    {
        _street = "";
        _town = "";
        _state = "";
        _country = "";
    }

    public Address(string street, string town, string state, string country)
    {
        _street = street;
        _town = town;
        _state = state;
        _country = country;
    }
    public string AddressString()
    {
        return $"{_street} {_town}, {_state}, {_country}";
    }
}