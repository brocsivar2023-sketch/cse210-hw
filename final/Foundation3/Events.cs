abstract class Events
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Events()
    {
        _eventTitle = "";
        _description = "";
        _date = "";
        _time = "";
        _address = new Address();
    }
    public Events(string eventTitle, string description, string date, string time)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
    }

    public void SetAddress(string street, string town, string state, string country)
    {
        _address = new Address(street, town, state, country);
    }
    private string AddressString()
    {
        return _address.AddressString();
    }

    public string StandardDetails()
    {
        return $"Event: {_eventTitle}, Description: {_description}, Date: {_date}, Time: {_time}, Address: {AddressString()} ";
    }

    public virtual string ShortDetails()
    {
        return $"Title: {_eventTitle}, Date: {_date}";

    }
    public abstract string FullDetails();
}