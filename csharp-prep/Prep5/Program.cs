using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string num = Console.ReadLine();
        int number = int.Parse(num);
        return number;
    }
    
    static void PromtUserBirthYear(out int birthYear)
    {
        Console.Write("What is your Birth Year? ");
        string birth = Console.ReadLine();
        birthYear = int.Parse(birth);
    }

    static int SquareNumber(int num)
    {
        int sqrNum = num * num;
        return sqrNum;
    }

    static void DisplayResult(string name, int num, int birthyear)
    {
        Console.WriteLine($"{name}, your number squared is {num}. ");
        int age = 2026 - birthyear;
        Console.WriteLine($"You will turn {age} this year. ");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int birthYear;
        PromtUserBirthYear(out birthYear);
        int sqauredNumber = SquareNumber(favNum);
        DisplayResult(name, favNum, birthYear);




    }
}