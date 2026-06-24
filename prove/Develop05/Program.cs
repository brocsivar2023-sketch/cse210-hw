using System;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        BaseGoal myBase = new BaseGoal();
        myBase.SetName();
        myBase.SetDescription();
        myBase.SetNumberOfPoints();
        Console.WriteLine(myBase.GetDisplayString());
        myBase.MarkComplete();
        Console.WriteLine(myBase.GetDisplayString());
    }
}