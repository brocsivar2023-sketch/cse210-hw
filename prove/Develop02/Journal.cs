public class Journal
{
    List<JournalEntry> _journalEntries = new List<JournalEntry>();

    public void AddJournalEntry(JournalEntry journalEntry)
    {
        _journalEntries.Add(journalEntry);
    }

    public void DisplayJournal()
    {
        foreach(JournalEntry journalEntry in _journalEntries)
        {
            journalEntry.DisplayJournalEntry();
        }
    }
    public void WriteToFile(string fileName)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach(JournalEntry entry in _journalEntries)
                {
                    outputFile.WriteLine(entry.CreateFileSytemString());
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error something didn't work");
        }
    }
    public void ReadFromFile(string fileName)
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split("%");
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                JournalEntry journalEntry = new JournalEntry();
                journalEntry._date = date;
                journalEntry._prompt = prompt;
                journalEntry._response = response;
                _journalEntries.Add(journalEntry);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error file not found");
        }
    }
    public void DeleteAJournal()
    {
        Console.WriteLine("Please choose which entry to delete. The index will appear like this [example]\n Please enter in that number after the list iterates. ");
        int i = 0;
        foreach (JournalEntry entry in _journalEntries)
        {
            Console.Write($"[{i}]:");
            entry.DisplayJournalEntry();
            Console.WriteLine("");
            i++;
        }
        try
        {
            Console.WriteLine("Enter the index you would like to delete: ");
            int index = int.Parse(Console.ReadLine());
            _journalEntries.RemoveAt(index);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error that is not a valid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error the number is too large or to small");
        }
    }
}