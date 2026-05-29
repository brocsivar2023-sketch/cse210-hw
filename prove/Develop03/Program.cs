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


        Scripture myScripture = new Scripture("Matthew", 15, 21, "Hello, I'm amazing and you wish you were this amazing");
        myScripture.ShowScripture();
        myScripture.HideSomeWords();
        myScripture.ShowScripture();
        Scripture myScripture2 = new Scripture("Matthew", 15, 21, 13, "Hello, I'm amazing and you wish I was soo cool. ");
        myScripture2.ShowScripture();
        myScripture2.HideSomeWords();
        myScripture2.ShowScripture();
        Scripture myScripture3 = new Scripture(myScriptureReference, "Hello, I'm amazing and so hot");
        myScripture3.ShowScripture();
        myScripture3.HideSomeWords();
        myScripture3.ShowScripture();

    }
}