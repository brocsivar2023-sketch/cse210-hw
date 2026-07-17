abstract class Activity
{
    private string _date;
    private int _length;
    private string _activityName;

    public Activity()
    {
        _date = "";
        _length = 0;
        _activityName = "";
    }

    public Activity(string date, int length, string activityName)
    {
        _date = date;
        _length = length;
        _activityName = activityName;
    }

    protected int GetLength()
    {
        return _length;
    }

    public string GetSummary()
    {
        return $"Date: {_date} {_activityName} ({_length} min)- Distance {Distance():F2} miles, Speed {Speed():F2} mph, Pace: {Pace():F2} min per mile";
    }

    protected abstract double Speed();
    protected abstract double Pace();
    protected abstract double Distance();
}