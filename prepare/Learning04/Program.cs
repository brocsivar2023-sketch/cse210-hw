using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {

        MathAssignment myMathassignment = new MathAssignment("Section 7.3", "Problems 8-19", "Roberto Rodriguez", "Fractions");
        Console.WriteLine(myMathassignment.GetMath());
        WritingAssignment myWrting = new WritingAssignment("The Causes of World War II by Mary Waters", "Mary Waters", "European History");
        Console.WriteLine(myWrting.GetHomeworkList());
    }
}