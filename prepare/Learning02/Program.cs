using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        job job1 = new job();
        job1._jobTitle = "Software Engeneer";
        job1._company = "Apple Inc.";
        job1._startYear= 2019;
        job1._endYear = 2021;

        job job2 = new job();
        job2._jobTitle = "Manager";
        job2._company = "Microsoft";
        job2._startYear = 2021;
        job2._endYear = 2023;

        resume myResume = new resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}