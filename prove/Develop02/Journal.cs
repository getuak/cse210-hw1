using System;
using System.Collections.Generic;

public class Journal
{
    public string JournalName { get; set; }
    public List<JournalEntry> Entries { get; set; }

    public Journal(string journalName)
    {
        JournalName = journalName;
        Entries = new List<JournalEntry>();
    }

    public void AddEntry(JournalEntry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
        }
        else
        {
            Console.WriteLine($"Journal: {JournalName}\nEntries:");

            foreach (var entry in Entries)
            {
                Console.WriteLine(entry);
            }
        }
    }
}