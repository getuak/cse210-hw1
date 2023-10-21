using System;


class Job
{
    public string Company { get; set; }
    public string JobTitle { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }
}

class Resume
{
    public string Name { get; set; }
    public List<Job> Jobs { get; set; }

    public void DisplayResume()
    {
        Console.WriteLine($"Resume of {Name}\n");
        foreach (var job in Jobs)
        {
            Console.WriteLine($"Company: {job.Company}");
            Console.WriteLine($"Job Title: {job.JobTitle}");
            Console.WriteLine($"Start Year: {job.StartYear}");
            Console.WriteLine($"End Year: {job.EndYear}\n");
        }
    }
}




