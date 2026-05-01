using System;
using System.Runtime.Versioning;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int magicGuess = 0;
        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            magicGuess = int.Parse(guess);
            if (magicGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (magicGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You got it right!");
            }
        } while (magicNumber != magicGuess);
    }
}