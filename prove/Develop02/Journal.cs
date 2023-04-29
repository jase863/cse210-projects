using System.IO;
using System.Collections.Generic;
public class Journal
{
    public List<Entry> entries = new List<Entry>();
    public List<string> strEntries = new List<string>();
    
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void AddLoadedEntry(string entry)
    {
        strEntries.Add(entry);
    }

    public void SaveToFile(string file, Journal journalInfo)
    {
        // add entries to csv
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in journalInfo.entries)
            {
                // convert entries to a good format for CSV files 
                string strEntry = entry.EntryCSV(entry);

                outputFile.WriteLine(strEntry);
            }

            foreach (string loaded in journalInfo.strEntries)
            {
                // add CSV read strings to CSV file
                Console.WriteLine(loaded);
                outputFile.WriteLine(loaded);
            }
        }
        LoadFile(file);
    }

   public void LoadFile(string fileToOpen)
   {
        Journal journalCSV = new Journal();
        List<string> entries = new List<string>();
        
        string [] savedEntry = System.IO.File.ReadAllLines(fileToOpen);

        foreach (string entryPart in savedEntry)
        {
            string [] data = entryPart.Split("|");

            string date = data[0];
            string prompt = data[1];
            string entry = data[2];


            journalCSV.AddLoadedEntry($"{date}|{prompt}|{entry}");

        }
        using (StreamWriter outputFile = new StreamWriter(fileToOpen))
        {
            foreach (string entry in journalCSV.strEntries)
            {

                outputFile.WriteLine(entry);

            }
        }
   }

   public void DisplayAll()
   { 

    foreach (Entry entry in entries)
    {
        entry.DisplayEntry();
    }

   }
   
   public void DiplayLoaded()
   {
    Entry holdEntry = new Entry();

    holdEntry.DisplayLoadedEntry();
   }
}
