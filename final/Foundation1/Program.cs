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

        foreach (Video video in videos)
        {
            Console.WriteLine(video.Print());
            Console.WriteLine("Comments made; ");
            video.PrintComments();
        }
    }
}