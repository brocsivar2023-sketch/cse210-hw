using System.Security.Cryptography.X509Certificates;

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
            bool y = true;
            while (y)
            {
                Random random = new Random();
                int x = random.Next(_words.Count);
                if (_words[x].IsHidden() == false)
                {
                    _words[x].Hide();
                    y = false;
                }
                else if (WordsShown() == 0)
                {
                    y = false;
                }
            }

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
    public int WordsShown()
    {
        int words = _words.Count;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == true)
            {
                words--;

            }

        }
        return words;
    }


}