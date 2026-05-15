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
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(JournalEntry entry in _journalEntries)
            {
                outputFile.WriteLine(entry.CreateFileSytemString());
            }
        }
    }
    public void ReadFromFile(string fileName)
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
}