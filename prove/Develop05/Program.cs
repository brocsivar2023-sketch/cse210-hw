using System;
using System.IO.Enumeration;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
       /* BaseGoal myBase = new BaseGoal();
        myBase.SetName();
        myBase.SetDescription();
        myBase.SetNumberOfPoints();
        Console.WriteLine(myBase.GetDisplayString());
        myBase.MarkComplete();
        Console.WriteLine(myBase.GetDisplayString());
        */
       /* SimpleGoal myGoal = new SimpleGoal();
        myGoal.CreateGoal();
        Console.WriteLine(myGoal.GetDisplayString());
        myGoal.RecordEvent();
        Console.WriteLine(myGoal.GetDisplayString()); */

        Goals mygoals = new Goals();

        int loopNum = 0;
        while (loopNum != 6)
        {
            Menu menu = new Menu();
            loopNum = menu.DisplayMenu();
            if (loopNum == 1)
            {
                int goalNum = menu.DisplayGoalMenu();
                if (goalNum == 1)
                {
                    SimpleGoal simple = new SimpleGoal();
                    simple.CreateGoal();
                    mygoals.AddGoal(simple);

                }
                else if (goalNum == 2)
                {
                    Eternal eternal = new Eternal();
                    eternal.CreateGoal();
                    mygoals.AddGoal(eternal);
                }
                else if (goalNum == 3)
                {
                    
                }
                else
                {
                    Console.WriteLine("You did something wrong. Try again ");
                }
            }
            else if (loopNum == 2)
            {
                mygoals.DisplayGoals();
                Console.WriteLine("Press enter to continue ");
                Console.ReadLine();
            }
            else if (loopNum == 3)
            {
                Console.WriteLine("What would you like to name the file? ");
                string filename = Console.ReadLine();
                mygoals.SaveGoals(filename);
            }
            else if (loopNum == 4)
            {
                Console.WriteLine("What is the file name? ");
                string filename = Console.ReadLine();
                mygoals.LoadGoals(filename);
                
            }
            else if (loopNum == 5)
            {
                
            }
            else if (loopNum == 6)
            {
                Console.WriteLine("You ended the program ");
            }
            else
            {
                Console.WriteLine("You did something wrong. Try again ");
            }
        }
    }
}