using System.Runtime.CompilerServices;

class Running : Activity
{
    private double _distance;

    public Running() : base()
    {
        _distance = 1;
    }

    public Running(string date, int length, double distance): base(date, length, "Running")
    {
        _distance = distance;
    }

    protected override double Distance()
    {
        return _distance;
    }

    protected override double Speed()
    {
        return _distance / GetLength() * 60;
    }

    protected override double Pace()
    {
       return GetLength() / _distance;
    }
}