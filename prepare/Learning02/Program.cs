using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2000;
        job1._endYear = 2012;
        // job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2000;
        job2._endYear = 2024;
        // job2.Display();

        Resume resume = new Resume();
        resume._person = "Reanu Keeves";
        resume._jobs.Add(job2);
        resume._jobs.Add(job1);
        resume.Display();
    }
}