using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._company = "Apple Inc.";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2025;
        job1._endYear = 2026;
        job1.Display();

        Job job2 = new Job();
        job2._company  = "Microsoft";
        job2._jobTitle = "Cybersecurity Technician";
        job2._startYear = 2020;
        job2._endYear = 2025;
        job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Christian Taylor";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
        
    }
}