using System;
using System.Threading;
using System.Collections.Generic;

// Common base class for all activities
class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Activity: {Name}");
        Console.WriteLine(Description);
        Console.Write("Enter duration (in seconds): ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); // Pause for 3 seconds
    }

    public virtual void End()
    {
        Console.WriteLine("You've done a good job!");
        Console.WriteLine($"Activity: {Name} completed in {Duration} seconds.");
        ShowSpinner(3); // Pause for 3 seconds
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); // Pause for 1 second
        }
    }
}
