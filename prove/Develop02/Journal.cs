public class Journal {
    public string JournalName {get; set;}
    public List<Entry> Entries {get; set;}

    public Journal()
    {
        Entries = new List<Entry>();
    }
}