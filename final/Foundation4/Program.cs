using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activityList = new List<Activity>();

        Running running = new Running("7 July 2026", 45, 2);
        _activityList.Add(running);
        Console.WriteLine(running.GetSummary());
    }
}