using System;
using System.Threading;
using System.Collections.Generic;
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
// start and end activity
    public override void Start()
    {
        base.Start();
        while (Duration > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3); // Pause for 3 seconds
            Duration -= 3;

            if (Duration <= 0)
                break;

            Console.WriteLine("Breathe out...");
            ShowSpinner(3); // Pause for 3 seconds
            Duration -= 3;
        }

        End();
    }
}