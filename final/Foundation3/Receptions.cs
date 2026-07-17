class Receptions : Events
{
    private string _email;

    public Receptions() : base ()
    {
        _email = "";
    }
    public Receptions(string eventTitle, string description, string date, string time, string email) : base(eventTitle, description, date, time)
    {
        _email = email;
    }

    public override string ShortDetails()
    {
        return base.ShortDetails() + " Event type: Receptions";
    }
    public override string FullDetails()
    {
        return "Event type: Receptions, " + StandardDetails() + $", Email to RSVP: {_email}";
    }
}