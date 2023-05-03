using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "sofware Engineer";
        job1._company = "Google";
        job1._StartYear = 2022;
        job1._EndYear = 2023;
        
        Job job2 = new Job();
        job2._jobTitle = "Senior developer";
        job2._company = "Microsoft";
        job2._StartYear = 2020;
        job2._EndYear = 2023;


        // Create a new instance of the Resume class

        Resume resume1 = new Resume();
        resume1._name = "Laurin vasquez";
        // Here I added the two jobs I created into the list
        resume1._job.Add(job1);
        resume1._job.Add(job2);
        // Display all job details:
        resume1.Display();
    }
}