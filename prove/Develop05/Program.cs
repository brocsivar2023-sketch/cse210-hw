using System;
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
                    
                }
                else if (goalNum == 2)
                {
                    
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
                
            }
            else if (loopNum == 3)
            {
                
            }
            else if (loopNum == 4)
            {
                
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