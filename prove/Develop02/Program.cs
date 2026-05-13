using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        JournalEntry journalEntry = new JournalEntry();
        journalEntry.CreateJournalEntry();
        journalEntry.DisplayJournalEntry();
    }
}