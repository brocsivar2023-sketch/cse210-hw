
class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine(_description);

        Console.WriteLine("How many seconds for this activity? ");
        _duration = int.Parse(Console.ReadLine());
    }
}