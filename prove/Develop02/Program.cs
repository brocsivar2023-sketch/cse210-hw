using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        JournalEntry journalEntry = new JournalEntry();
        journalEntry.CreateJournalEntry();
        // journalEntry.DisplayJournalEntry();
        // Console.WriteLine(journalEntry.CreateFileSytemString());
        JournalEntry journalEntry2 = new JournalEntry();
        journalEntry2.CreateJournalEntry();
        

        Journal journal = new Journal();
        journal.AddJournalEntry(journalEntry);
        journal.AddJournalEntry(journalEntry2);
        journal.DisplayJournal();

    }
}