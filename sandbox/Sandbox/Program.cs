using System;

class Program
{
    static void Main(string[] args)
    {
        // I'm an amazing man
        // and goodlooking too ;)
        Console.WriteLine("Hello Sandbox World!");
        int x = 10;
        if (x == 11)
        {
            Console.WriteLine("Hey bob");
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        int age = -2;
        while (age < 0 || age > 125)
        {
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
        }

    }
}