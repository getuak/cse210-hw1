using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Getu", "Home work1");

        Console.WriteLine(assignment1.GetAssignmentInformation());
    }
}