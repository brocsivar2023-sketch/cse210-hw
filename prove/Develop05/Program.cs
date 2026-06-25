using System;
using System.IO.Enumeration;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        Goals mygoals = new Goals();
        int totalPoints = 0;

        int loopNum = 0;
        while (loopNum != 6)
        {
            Console.WriteLine($"Your total amount of points are {totalPoints} points ");
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
                    Checklist checklist = new Checklist();
                    checklist.CreateGoal();
                    mygoals.AddGoal(checklist);
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
                int points = mygoals.RecordEvent();
                Console.WriteLine($"You earned {points} points ");
                totalPoints += points;
                Console.WriteLine($"Your total amount of points are {totalPoints} points ");

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