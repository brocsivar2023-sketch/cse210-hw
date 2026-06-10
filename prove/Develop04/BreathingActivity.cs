
class Breathing : BaseActivity
{
    public Breathing(string description) : base("Breathing", description)
    {
    }

    public void RunActivity()
    {
        StartActivity();
        RunCountdown("Breath In", 4);
        RunCountdown("Breath Out", 6);
    }
    
}