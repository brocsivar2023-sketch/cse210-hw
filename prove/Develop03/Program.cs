using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Hello");
        Console.WriteLine(myWord.GetWordString());
    }
}