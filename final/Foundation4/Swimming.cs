using System.ComponentModel;

class Swimming : Activity
{
    private int _laps;

    public Swimming() : base()
    {
        _laps = 1;
    }
    public Swimming(string date, int length, int laps): base(date, length, "Swimming")
    {
        _laps = laps;
    }

    protected override double Distance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    protected override double Pace()
    {
        return GetLength() / Distance();
    }

    protected override double Speed()
    {
        return 60 / Pace();
    }
}