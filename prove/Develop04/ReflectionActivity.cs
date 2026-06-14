class Reflection : BaseActivity
{
    public Reflection(string description) : base("Reflection", description)
    {
        SetDescription(description);
    }
    public void RunActivity()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Think of time you did something really difficult");
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you? ");
        questions.Add("Have you ever done anything like this before? ");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete? ");
        questions.Add("What made this time different than other times when you were not as successful? ");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations? ");
        questions.Add("What did you learn about yourself through this experience? ");
        questions.Add("How can you keep this experience in mind in the future? ");

        StartActivity();
        Console.WriteLine("Get Ready...");
        LoadingScreen();
        Console.WriteLine("Consider the folowing propmt: ");
        Console.WriteLine(prompts[Random.Shared.Next(prompts.Count)]);
        Console.WriteLine("When you have something in mind press Enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now Ponder each of the following questions as they relate to this experience. ");
        RunCountdown("You may begin in...", 3);
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while(DateTime.Now < endTime)
        {
            Console.Write(questions[Random.Shared.Next(questions.Count)]);
            LoadingScreen();
        }
        ClosingMessage();
    }

}