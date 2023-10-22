using System;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son.");
        var reference = new ScriptureReference("John 3:16");

        while (!scripture.AllWordsHidden)
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide a word, or type 'quit' to exit.");
            var input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWord();
        }
    }
}