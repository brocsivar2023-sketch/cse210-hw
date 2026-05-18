using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        for (int i = 1; i < 21; i++)
        {
            int top = Random.Shared.Next(1, 20);
            int bottom = Random.Shared.Next(1, 20);
            fraction.SetTop(top);
            fraction.SetBottom(bottom);
            Console.WriteLine($"Fraction {i} = {fraction.GetFractionString()}, Decimal {i} = {fraction.GetDecimalValue()}");
        }
    }
}