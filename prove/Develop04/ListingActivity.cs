using System.Security.Cryptography;

class Listing : BaseActivity
{
    public Listing(string description) : base("Listing", description)
    {
        SetDescription(description);
    }
    public void RunActivity()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate? ");
        prompts.Add("What are personal strengths of yours? ");
        prompts.Add("Who are people that you have helped this week? ");
        prompts.Add("When have you felt the Holy Ghost this month? ");
        prompts.Add("Who are some of your personal heroes? ");

        Console.Clear(); 
        
        StartActivity();
        int duration = GetDuration();
        Console.WriteLine("Get Ready...");
        LoadingScreen();
        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine(prompts[Random.Shared.Next(prompts.Count)]);
        RunCountdown("You may begin in...", 5);
        int numOfTimes = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while(DateTime.Now < endTime)
        {
            Console.Write("Message Here> ");
            Console.ReadLine();
            Console.WriteLine("");
            numOfTimes ++;
        }
        Console.WriteLine($"You Listed {numOfTimes} items!");
        ClosingMessage();
    }
}