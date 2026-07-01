using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Funny Dogs", "Sam", 5);
        video1.AddComments("Bill", "This was great!");
        video1.AddComments("Sam", "I hated this");
        video1.AddComments("Ted", "I found it interesting");

        videos.Add(video1);

        Video video2 = new Video("Funny Cats", "Katy", 20);
        video2.AddComments("Julianna", "I love cats");
        video2.AddComments("Kristy", "I hate cats");
        video2.AddComments("Susana", "I need milk");

        videos.Add(video2);

        Video video3 = new Video("Funny People", "Gary", 100);
        video3.AddComments("Ash", "I can't beleive I found this video!");
        video3.AddComments("Misty", "This video is unbelievable");
        video3.AddComments("Brock", "I love rocks");

        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.Print());
            Console.WriteLine("Comments made; ");
            video.PrintComments();
        }
    }
}