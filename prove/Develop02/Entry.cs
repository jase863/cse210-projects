public class Entry
{
    public string _prompt, _entry, _date;

    public string EntryCSV(Entry entry)
    {
        entry._prompt.ToString();
        entry._entry.ToString();
        entry._date.ToString();

        return ($"{entry._date}|{entry._prompt}|{entry._entry}");
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} - {_prompt}\n{_entry}\n");
    }

    public void DisplayLoadedEntry(string entry)
    {
        Console.WriteLine(entry);
    }
    
}
