public class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;
    
    //Need to create more prompts 
    public string[] _prompts =
    {
        "How are you feeling today?",
        "Who did you talk with today?",
        "What is something you're grateful for?"
    };

    public void CreateJournalEntry()
    {
        //to finish this code we need a randomizer for the prompts
        _prompt = _prompts[0];
        _date = DateTime.Now.ToShortDateString();
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();

    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date},{_prompt},{_response}");
    }
    
    public string CreateFileSytemString()
    {
        return $"{_date}, {_prompt}, {_response}";
    }
}