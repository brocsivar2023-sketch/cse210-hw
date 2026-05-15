using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        int menuItem = 0;
        Journal journal = new Journal();

        do
        {
            //Goes to menu class to display the instructions and title and to retrieve menu input
            Menu menu = new Menu();
            menu.DisplayTitle();
            menuItem = menu.ProcessMenu();


            // Writes a new journal Entry

            if (menuItem == 1)
            {
                JournalEntry journalEntry = new JournalEntry();
                journalEntry.CreateJournalEntry();
                journalEntry.DisplayJournalEntry();
                journal.AddJournalEntry(journalEntry);
            }
            // Displays all of the journal entries in the journal
            else if (menuItem == 2)
            {
                journal.DisplayJournal();
            }
            // Loads a different jounral from the file
            else if (menuItem == 3)
            {
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                journal.ReadFromFile(fileName);
            }
            // Saves your journal to a file
            else if (menuItem == 4)
            {
                Console.WriteLine("What is the name of your file? ");
                string _fileName = Console.ReadLine();
                journal.WriteToFile(_fileName);
            }
            // Ends the program
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