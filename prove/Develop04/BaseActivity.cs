
using Microsoft.VisualBasic;

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
    public void SetDescription(string descirption)
    {
        _description = descirption;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine(_description);

        Console.WriteLine("How long in seconds would you like this activity? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void RunCountdown(string message, int duration)
    {
        Console.Write($"{message}: ");
        while(duration >= 0)
        {
            Console.Write($"{duration--,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine("");
    }
    public void LoadingScreen()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        while (DateTime.Now < endTime)
        {
            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("\\");
            animationStrings.Add("-");
            animationStrings.Add("/");
            animationStrings.Add("|");
            animationStrings.Add("\\");
            animationStrings.Add("-");
            animationStrings.Add("/");
            animationStrings.Add("|");
            foreach(string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
        Console.WriteLine("");
        
    }
    public void ClosingMessage()
    {
        Console.WriteLine("Well Done!!!");

        LoadingScreen();
        
        Console.WriteLine($"Congratulations you have completed {_duration} seconds of the {_name} Activity! ");
        
        LoadingScreen();
    }
}