using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2000;
        job1._endYear = 2008;

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Adobe";
        job2._startYear = 2010;
        job2._endYear = 2012;

        job1.Display();
        job2.Display();

        Resume resume = new Resume();
        resume._name = "Benjamin Walker";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}