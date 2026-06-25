using System;
using System.IO.Enumeration;
using System.Net.Security;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Goals myGoals = new Goals();

        int loopNum = 0;
        while (loopNum != 6)
        {
            Console.WriteLine($"Your total amount of points are {myGoals.GetPoints()} points ");
            Menu menu = new Menu();
            loopNum = menu.DisplayMenu();
            if (loopNum == 1)
            {
                Console.Clear();
                int goalNum = menu.DisplayGoalMenu();
                if (goalNum == 1)
                {
                    SimpleGoal simple = new SimpleGoal();
                    simple.CreateGoal();
                    myGoals.AddGoal(simple);
                }
                else if (goalNum == 2)
                {
                    Eternal eternal = new Eternal();
                    eternal.CreateGoal();
                    myGoals.AddGoal(eternal);
                }
                else if (goalNum == 3)
                {
                    Checklist checklist = new Checklist();
                    checklist.CreateGoal();
                    myGoals.AddGoal(checklist);
                }
                else
                {
                    Console.WriteLine("You did something wrong. Try again ");
                }
                Console.Clear();
            }
            else if (loopNum == 2)
            {
                Console.Clear();
                myGoals.DisplayGoals();
                Console.WriteLine("Press enter to continue ");
                Console.ReadLine();
            }
            else if (loopNum == 3)
            {
                Console.Clear();
                Console.WriteLine("What would you like to name the file? ");
                string filename = Console.ReadLine();
                myGoals.SaveGoals(filename);
            }
            else if (loopNum == 4)
            {
                Console.Clear();
                Console.WriteLine("What is the file name? ");
                string filename = Console.ReadLine();
                myGoals.LoadGoals(filename);
                
            }
            else if (loopNum == 5)
            {
                Console.Clear();
                myGoals.RecordEvent();

            }
            else if (loopNum == 6)
            {
                Console.Clear();
                Console.WriteLine("You ended the program ");
                Console.WriteLine("Press Enter to continue ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You did something wrong. Try again ");
            }
            Console.Clear();
        }
    }
}