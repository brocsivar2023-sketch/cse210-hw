public class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string[] _prompts =
    {
        "How are you feeling today",
        "Who did you talk with today",
        "What is something you're grateful for?"
    };

    public void CreateJournalEntry()
    {
        _prompt = _prompts[0];
        _date = DateTime.Now.ToShortDateString();
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
        
    }
}