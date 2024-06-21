using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.IO.Enumeration;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void LogEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveAll(string file)
    {
        Console.WriteLine("Please select a file name");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }
    }

    public void LoadAll(string file)
    {
        _entries = new List<Entry>();
        Console.WriteLine("Please select a file name");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string entrySplit = parts[2];
            Entry entry = new Entry();
            entry._date = date;
            entry._promptText = prompt;
            entry._entryText = entrySplit;
            LogEntry(entry);
        }
    }
}