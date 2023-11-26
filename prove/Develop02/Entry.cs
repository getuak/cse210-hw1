using System;

using System.Collections.Generic;

using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class JournalEntry
     {
    public string EntryDate {get; set;}

    public string Prompt {get; set;}

    public string Response {get; set;}

    private DateTime Date;
    

    public JournalEntry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;

        return $"[{Date}] {Prompt}: {Response}";
        
    }



}