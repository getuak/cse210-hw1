using System;

class ScriptureWord
{
    public string Word { get; }
    public bool Hidden { get; private set; }

    public ScriptureWord(string word)
    {
        Word = word;
        Hidden = false;
    }

    public void Hide()
    {
        Hidden = true;
    }
}