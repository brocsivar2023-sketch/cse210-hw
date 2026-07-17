class Cycling : Activity
{
    private double _speed;

    public Cycling() : base()
    {
        _speed = 1;
    }
    public Cycling(string date, int length, double speed): base(date, length, "Cycling")
    {
        _speed = speed;
    }

    protected override double Speed()
    {
        return _speed;
    }
    protected override double Pace()
    {
        return 60 / _speed;
    }

    protected override double Distance()
    {
        return _speed / GetLength() * 60;
    }
}