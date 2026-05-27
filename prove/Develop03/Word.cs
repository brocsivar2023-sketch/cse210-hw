class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public string GetWordString()
    {
        // Not done need to give it back will give back underscores
        return _word;
    }
}