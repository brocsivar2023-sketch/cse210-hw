class Lectures : Events
{
    private string _speaker;
    private int _capacity;

    public Lectures() : base()
    {
        _speaker = "";
        _capacity = 0;
    }

    public Lectures(string eventTitle, string description, string date, string time, string speaker, int capacity) : base(eventTitle, description, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string ShortDetails()
    {
        return base.ShortDetails() + " Event type: Lectures";
    }
    public override string FullDetails()
    {
        return "Event type: Lectures, " + StandardDetails() + $", Speaker: {_speaker}, Capacity: {_capacity} persons";
    }
}