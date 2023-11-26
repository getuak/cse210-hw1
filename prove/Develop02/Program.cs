using System;

using System.Collections.Generic;

using System.IO;

class Menu
{
    public static void DisplayMenu()
    {
        Console.WriteLine("Journal Menu:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Quit");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal("Getu");

        while (true)
        {
            Menu.DisplayMenu();
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal);
                    break;
                case "2":
                    DisplayJournal(journal);
                    break;
                case "3":
                    SaveJournalToFile(journal);
                    break;
                case "4":
                    LoadJournalFromFile(journal);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void LoadJournalFromFile(Journal journal)
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();
    }

    private static void SaveJournalToFile(Journal journal)
    {
        Console.Write("Enter a filename to save the journal: ");
        string filename = Console.ReadLine();
        List<JournalEntry> entries = journal.Entries;
    }

    private static void DisplayJournal(Journal journal)
    {
         List<JournalEntry> entries = journal.Entries;

        if (entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            Console.WriteLine("Journal Entries:");
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    

            JournalEntry entry = new JournalEntry(prompts[promptNumber - 1], response);
            journal.AddEntry(entry);
            Console.WriteLine("Entry added successfully.");

            JournalEntry entry = new JournalEntry(prompt, response, date);
            AddEntry(entry);
}
