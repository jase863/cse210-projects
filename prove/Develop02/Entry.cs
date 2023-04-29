public class Entry
{
    public string prompt, entry, date;

    public string EntryCSV(Entry entry)
    {
        // entry.prompt.ToString();
        // entry.entry.ToString();
        // entry.date.ToString();

        return ($"{entry.date}|{entry.prompt}|{entry.entry}");
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{date} - {prompt}\n{entry}\n");
    }

    public void DisplayLoadedEntry()
    {
        Journal journal = new Journal();

        foreach (string entryPart in journal.strEntries)
        {
            string [] data = entryPart.Split("|");

            string date = data[0];
            string prompt = data[1];
            string entry = data[2];
        }
        Console.WriteLine($"{date} - {prompt}\n{entry}\n");

    }
    
}
