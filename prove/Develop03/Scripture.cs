class Scripture
{
    private List<Word> _words;
    private ScriptureReference _reference;
    
    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(book, chapter, verse);

        _words = ConvertToWords(text);
    }
    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new ScriptureReference(book, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }
    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
       
        _words = ConvertToWords(text);
    }

    private List<Word> ConvertToWords(string text)
    {
        List<Word> words = new List<Word>();
        string[] split = text.Split(' ');

        foreach (string word in split)
        {
             words.Add(new Word(word));
        }
        return words;
    }
    
    public void HideSomeWords()
    {
        for (int i = 0; i < 3; i++)
        {
            int x = Random.Shared.Next(_words.Count);
            _words[x].Hide();
        }
    }

    public void ShowScripture()
    {
        _reference.ShowScriptureReference();
        foreach (Word word in _words)
        {
            word.DisplayWord();
        }
        Console.WriteLine(' ');
    }


}