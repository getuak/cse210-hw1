using System;
using System.Threading;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on various aspects of your life.")
    {
    }

    public override void Start()
    {
        base.Start();

        while (Duration > 0)
        {
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine(randomPrompt);

            ShowSpinner(3); // Pause for 3 seconds

            foreach (string prompt in prompts)
            {
                Console.WriteLine(prompt);
                ShowSpinner(3); // Pause for 3 seconds
                Duration -= 3;
                if (Duration <= 0)
                    break;
            }
        }

        End();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}




