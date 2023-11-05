using System;
using System.Threading;
using System.Collections.Generic;

class ListingActivity : Activity
{
     // standard starting message
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")

    {
    }

    // random prompt to show to the user
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
// give the user countdown of several seconds andprompt them to keep listing
    public override void Start()
    {
        base.Start();

        while (Duration > 0)
        {
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine(randomPrompt);
// Pause 3 seconds
            ShowSpinner(3); 

            foreach (string prompt in prompts)
            {
                Console.WriteLine(prompt);
                ShowSpinner(3); 
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




