class Program
{
    public static void Main(string[] args)
    {
        sleepTime = 1000;
        string animationString = " \|/";
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(10);
        int index = 0;
        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length()]);
            Thread.Sleep(sleepTime);
            Console.Write("/b");
        }

        Console.CursorVisible = true;
    }
}