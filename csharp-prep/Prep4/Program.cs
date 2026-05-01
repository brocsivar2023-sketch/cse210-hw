using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber_to = -1;

        do
        {
            Console.Write("Add a new number to the list (to stop enter 0)");
            string newNumber = Console.ReadLine();
            newNumber_to = int.Parse(newNumber);
            if (newNumber_to != 0)
            {
                numbers.Add(newNumber_to);
            }

        } while(newNumber_to != 0);

        int sum = 0;
        int maxNum = 0;

        foreach (int number in numbers)
        {
            sum += number;
            if (number > maxNum)
            {
                maxNum = number;
            }
        }
        Console.WriteLine($"The sum is {sum}");

        double average = sum / numbers.Count;
        Console.WriteLine($"The average is {average:0.00}");

        Console.WriteLine($"The maximum number is {maxNum}");

    }
}