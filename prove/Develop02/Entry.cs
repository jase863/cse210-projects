public class Entry
{
    public string _prompt, _entry, _date;

    public string EntryCSV(Entry entry)
    {
        // entry.prompt.ToString();
        // entry.entry.ToString();
        // entry.date.ToString();

        return ($"{entry._date}|{entry._prompt}|{entry._entry}");
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} - {_prompt}\n{_entry}\n");
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
        Console.WriteLine($"{_date} - {_prompt}\n{_entry}\n");

    }
    
}
