public class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response; 
    public string[] _prompts =
    {
        "Did you see the hand of the Lord in your life today? ",
        "What was something you enjoyed today?",
        "What was something that frustrated you?",
        "What where all of the different emotions that you felt today?",
        "Did you get overlly stressed? Why? "
    };

    public void CreateJournalEntry()
    {
        _prompt = _prompts[Random.Shared.Next(_prompts.Count())];
        _date = DateTime.Now.ToShortDateString();
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();

    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"Date: {_date}, Prompt: {_prompt} \n Response: {_response}");
    }
    
    public string CreateFileSytemString()
    {
        return $"{_date}%{_prompt}%{_response}";
    }
}