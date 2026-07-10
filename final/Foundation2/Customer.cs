using System.Security.Cryptography.X509Certificates;

class Customer
{
    private string _name;
    private Address _address;

    public Customer()
    {
        _name = "";
        _address = new Address();
    }
    public Customer(string name)
    {
        _name = name;
        _address = new Address();
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

    public void CreateNewAddress(string street, string city, string state, string country)
    {
        _address.SetCity(city);
        _address.SetStreet(street);
        _address.SetCountry(country);
        _address.SetState(state);
    }

    public bool IfUSa()
    {
        return _address.IfUSA();
    }
    public string AddressString()
    {
        return _address.StringLine();
    }
}