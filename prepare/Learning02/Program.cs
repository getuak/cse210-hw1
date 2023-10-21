using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            Company = "BYU-I",
            JobTitle = "Facilities Manager",
            StartYear = 2020,
            EndYear = 2023
        };
        
        Job job2 = new Job
        {
            Company = "Marvel",
            JobTitle = "Electrical Engineer",
            StartYear = 2018,
            EndYear = 2025
        };

        Resume resume1 = new Resume
        {
            Name = "Getu Keno",
            Jobs = new List<Job> { job1, job2 }
        };

        resume1.DisplayResume();
    }
}