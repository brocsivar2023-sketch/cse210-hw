using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string book = "Matthew";
        int chapter = 15;
        int startVerse = 1;
        int endVerse = 5;
        string text = "1 Then came to Jesus scribes and Pharisees, which were of Jerusalem, saying, 2 Why do thy disciples transgress the tradition of the elders? for they wash not their hands when they eat bread. 3 But he answered and said unto them, Why do ye also transgress the commandment of God by your tradition? 4 For God commanded, saying, Honour thy father and mother: and, He that curseth father or mother, let him die the death. 5 But ye say, Whosoever shall say to his father or his mother, It is a gift, by whatsoever thou mightest be profited by me;";
        Scripture myScripture = new Scripture(book, chapter, startVerse, endVerse, text);
        bool end = false;
        while(end != false)
        {
            myScripture.ShowScripture();
            myScripture.HideSomeWords();
            end = myScripture.AllWordsHidden();
        }
    }
}