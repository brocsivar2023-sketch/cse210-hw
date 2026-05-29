using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Hello");
        Console.WriteLine(myWord.GetWordString());

        myWord.Hide();
        Console.WriteLine(myWord.GetWordString());

        myWord.DisplayWord();
        if (myWord.IsHidden())
        {
            Console.WriteLine(myWord.GetWordString());
        }

        ScriptureReference myScriptureReference = new ScriptureReference("Matthew", 15, 1);
        Console.WriteLine(myScriptureReference.GetScriptureReference());
        myScriptureReference.ShowScriptureReference();
        
        ScriptureReference myScriptureReference2 = new ScriptureReference("Matthew", 15, 1, 7);
        Console.WriteLine(myScriptureReference2.GetScriptureReference());
        myScriptureReference2.ShowScriptureReference();
    }
}