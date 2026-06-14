
class Breathing : BaseActivity
{
    public Breathing(string description) : base("Breathing", description)
    {
        SetDescription(description);
    }

    public void RunActivity()
    {
        StartActivity();
        Console.WriteLine("Get ready...");
        LoadingScreen();
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            RunCountdown("Breath In", 4);
            RunCountdown("Breath Out", 6);
        }
        ClosingMessage();
    }

}