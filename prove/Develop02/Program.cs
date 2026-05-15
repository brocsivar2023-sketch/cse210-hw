using System;

class Program
{
    static void Main(string[] args)
    {
        int menuItem = 0;
        do
        {
            Menu menu = new Menu();
            menu.DisplayTitle();
            menuItem = menu.ProcessMenu();

            if (menuItem == 1)
            {
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
            else if (menuItem == 2)
            {
                Console.WriteLine("#2");
            }
            else if (menuItem == 3)
            {
                Console.WriteLine("#3");
            }
            else if (menuItem == 4)
            {
                Console.WriteLine("#4");
            }
            else if (menuItem == 5)
            {
                Console.WriteLine("You ended the program");
            }
            else
            {
                Console.WriteLine("You entered in a wrong value or number try again. ");
            }
        } while (menuItem != 5);

    }
}