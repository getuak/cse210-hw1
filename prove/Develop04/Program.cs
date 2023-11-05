using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Activity breathing = new BreathingActivity();
                    breathing.Start();
                    break;
                case "2":
                    Activity reflection = new ReflectionActivity();
                    reflection.Start();
                    break;
                case "3":
                    Console.WriteLine("goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("invalid choice. Please select again.");
                    break;
    
            }
        }
    }

    
}





   