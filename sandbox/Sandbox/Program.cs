using System;

class Program
{

    static void DisplayGreeting()
    {
        Console.WriteLine("Hello Betty");
    }

    static double AddNumbers(int n1, int n2, double n3)
    {
        double total = n1 + n2 + n3;
        return total;
    }



    static void Main(string[] args)
    {
        DisplayGreeting();
        double total = AddNumbers(10, 20, 1001.234);
        Console.WriteLine(total);
    //     // I'm an amazing man
    //     // and goodlooking too ;)
    //     Console.WriteLine("Hello Sandbox World!");
    //     int x = 10;
    //     if (x == 11)
    //     {
    //         Console.WriteLine("Hey bob");
    //     }

    //     for (int i = 0; i < 10; i++)
    //     {
    //         Console.WriteLine(i);
    //     }

    //     int age = -2;
    //     while (age < 0 || age > 125)
    //     {
    //         Console.WriteLine("Enter your age");
    //         age = int.Parse(Console.ReadLine());
    //     }

    //     for(int i = 0; i <= 32; ++i)
    //     {
    //         int powerNumber = (int)Math.Pow(2, i);
    //         Console.Write($"2 tp the power of {i}, i = {powerNumber}");
    //         Console.WriteLine($", 0X{powerNumber.ToString("X")}");
    //     }

    //     List<int> myData = new List<int>();
    //     myData.Add(1);
    //     myData.Add(2);
    //     myData.Add(3);
    //     myData.Add(4);
    //     myData.Add(5);
    //     myData.Add(99);
    //     myData.Add(-100);
    //     foreach(int i in myData)
    //     {
    //         Console.WriteLine(i);
    //     }
     }
}