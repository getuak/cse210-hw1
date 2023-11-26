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

    static void WriteNewEntry(Journal journal)
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Console.WriteLine("Choose a prompt from the list:");

        for (int i = 0; i < prompts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {prompts[i]}");
        }

        Console.Write("Select a prompt number: ");
        if (int.TryParse(Console.ReadLine(), out int promptNumber) && promptNumber >= 1 && promptNumber <= prompts.Count)
        {
            Console.Write("Write your response: ");
            string response = Console.ReadLine();
            else
        {
            Console.WriteLine("Invalid prompt number.");
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
    public void SaveJournaltoFile(string filename)
    {
      using (StreamWriter write = new StreamWriter(filename))
      {
        foreach(var entry in Entries)
        {
            Console.WriteLine($"{entry.Prompt} {entry.Response} {entry.Date}");
        }

        }
        Console.WriteLine("Journal Saved");
    }  
       public void LoadJournalFromFile(string filename)
       {
         Entries.Clear(); // Clear existing entries before loading

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        string prompt = parts[0];
                        string response = parts[1];
                        DateTime date = DateTime.Parse(parts[2]);

                        
                    }
                }
            }
        }     

    
}
    
  
