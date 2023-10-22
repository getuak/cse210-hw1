using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Scripture
{
    private readonly string fullScripture;
    private readonly List<ScriptureWord> wordsToHide;

    public Scripture(string reference, string text)
    {
        fullScripture = $"{reference}: {text}";
        wordsToHide = text.Split(' ').Select(word => new ScriptureWord(word)).ToList();
    }

    public bool AllWordsHidden => wordsToHide.All(word => word.Hidden);

    public void HideRandomWord()
    {
        var random = new Random();
        var visibleWords = wordsToHide.Where(word => !word.Hidden).ToList();
        if (visibleWords.Count > 0)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(fullScripture);
    }
}