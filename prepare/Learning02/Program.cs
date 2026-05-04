using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2005;
        job1._endYear = 2027;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Microsoft";
        job2._startYear = 1982;
        job2._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name = "Broc";
        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);
        myResume.Display();

    }
}