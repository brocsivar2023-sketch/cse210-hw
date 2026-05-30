using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;
/*
I created 3 different classes that uses the text and reference for each of the scriptures and makes it so the person
can memorize it. For my exceeding requirments I made it so multiple scriptures can be used so that each of the 
text of the scriptures is only accesed through a dictionary. It handles situations if there is only one verse used or 
more than 2 verses.
*/
class Program
{
    static void Main(string[] args)
    {
        List<string> reference = new List<string>();
        reference.Add("Matthew;15;1;5");
        reference.Add("John;3;6");
        reference.Add("Proverbs;3;5;6");
        reference.Add("2 Nephi;31;20");
        reference.Add("1 Nephi;3;5");

        Dictionary<string,string> scriptureText = new Dictionary<string, string>();
        scriptureText.Add("Matthew;15;1;5","1 Then came to Jesus scribes and Pharisees, which were of Jerusalem, saying, 2 Why do thy disciples transgress the tradition of the elders? for they wash not their hands when they eat bread. 3 But he answered and said unto them, Why do ye also transgress the commandment of God by your tradition? 4 For God commanded, saying, Honour thy father and mother: and, He that curseth father or mother, let him die the death. 5 But ye say, Whosoever shall say to his father or his mother, It is a gift, by whatsoever thou mightest be profited by me;");
        scriptureText.Add("John;3;6", "6 That which is born of the flesh is flesh; and that which is born of the Spirit is spirit.");
        scriptureText.Add("Proverbs;3;5;6", "5 Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths.");
        scriptureText.Add("2 Nephi;31;20", "20 Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.");
        scriptureText.Add("1 Nephi;3;5", "5 And now, behold thy brothers murmur, saying it is a hard thing which I have required of them; but behold I have not required it of them, but it is a commandment of the Lord.");

        Random random = new Random();
        int x = random.Next(reference.Count);
        string[] split = reference[x].Split(';');
        string book = split[0];
        int chapter = StringToInt(split[1]);
        int startVerse = StringToInt(split[2]);
        int endVerse = 0;

        if (split.Length == 4)
        {
            endVerse = StringToInt(split[3]);
        }

        string text = scriptureText[reference[x]];
        Scripture myScripture = new Scripture(book, chapter, startVerse, endVerse, text);

        int end = 40000;
        myScripture.ShowScripture();
        Console.WriteLine("Welcome to the scripture memorizer program! Press enter to continue ");
        Console.ReadLine();
        Console.Clear();
        while(end != 0)
        {
            myScripture.HideSomeWords();
            myScripture.ShowScripture();
            end = myScripture.WordsShown();
            Console.WriteLine("Press enter to continue or 'quit' to finish ");
            string userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                end = 0;
            }
            Console.Clear();
        }

        static int StringToInt(string num)
        {
            return int.Parse(num);
        }
    }
}