class Receptions : Events
{
    private int _numRsvp;

    public Receptions() : base ()
    {
        _numRsvp = 0;
    }
    public Receptions(string eventTitle, string description, string date, string time, int numRsvp) : base(eventTitle, description, date, time)
    {
        _numRsvp = numRsvp;
    }

    public override string ShortDetails()
    {
        return base.ShortDetails() + " Event type: Receptions";
    }
    public override string FullDetails()
    {
        return StandardDetails() + $", Reservations: {_numRsvp}";
    }
}