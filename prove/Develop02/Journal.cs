using System;
using System.IO;

//show
public class Journal
{
    public static List<Entry> _entries = new List<Entry>();

    public void addEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Save()
    {
        Console.WriteLine("Please enter the journal's file name: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
           foreach (Entry entry in _entries)
           {
            outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._entry}");
           }
        }
    }

    public void Load()
    {
        Console.WriteLine("Please enter the journal's file name: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _entries.Clear();
        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split("~");
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._entry = parts[2];
            _entries.Add(entry);
        }
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}
