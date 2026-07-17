using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activityList = new List<Activity>();

        Running running = new Running("7 July 2026", 45, 2);
        _activityList.Add(running);

        Cycling cycling = new Cycling("10 July 2026", 30, 15);
        _activityList.Add(cycling);

        Swimming swimming = new Swimming("11 July 2026", 15, 40);
        _activityList.Add(swimming);

        foreach(Activity activity in _activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}