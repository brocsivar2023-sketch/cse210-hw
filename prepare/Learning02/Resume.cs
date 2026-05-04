using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

public class Resume
{
    public string _name;
    public List<Job> jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        foreach (var job in jobs)
        {
            job.Display();
        }
    }
}