using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage grade? (Use Whole Numbers) ");
        string userPercentage = Console.ReadLine();
        int percentage = int.Parse(userPercentage);
        
        string letter_grade = "0";

        if (percentage >= 90)
        {
            letter_grade = "A";
        }
        else if (percentage >= 80)
        {
            letter_grade = "B";
        }
        else if (percentage >= 70)
        {
            letter_grade = "C";
        }
        else if (percentage >= 60)
        {
            letter_grade = "D";
        }
        else if (percentage >= 0)
        {
            letter_grade = "F";
        }

        Console.WriteLine($"Your letter grade is {letter_grade}");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You Failed!");
        }
        

    }
}