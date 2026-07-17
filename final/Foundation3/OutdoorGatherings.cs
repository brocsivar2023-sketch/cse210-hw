class OutdoorGatherings : Events
{
    private string _weather;

    public OutdoorGatherings() : base()
    {
        _weather = "";
    }
    public OutdoorGatherings(string eventTitle, string description, string date, string time, string weather) : base(eventTitle, description, date, time)
    {
        _weather = weather;
    }

    public override string ShortDetails()
    {
        return base.ShortDetails() + " Event type: Outdoor Gatherings";
    }
    public override string FullDetails()
    {
        return "Event type: Outdoor Gatherings, " + StandardDetails() + $", Weather: {_weather}";
    }
}