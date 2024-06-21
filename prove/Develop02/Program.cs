using System;
using System.Diagnostics;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        // Entry entry = new Entry();
        // entry.InputEntry();
        // entry.Display();

        // Journal logs = new Journal();
        // logs.LogEntry(entry);

        bool finished = false;

        Journal journal = new Journal();

        do {
            WriteLine("1 - Log Entry");
            WriteLine("2 - Display Entries");
            WriteLine("3 - Save Entries");
            WriteLine("4 - Load Entries");

            int option = int.Parse(ReadLine());

            string savefile = "";
            string loadfile = "";

            switch(option)
            {
                case 1:
                    Entry entry = new Entry();
                    entry.InputEntry();
                    journal.LogEntry(entry);

                    break;
                case 2:
                    journal.DisplayAll();

                    break;
                case 3:
                    journal.SaveAll(savefile);

                    break;
                case 4:
                    journal.LoadAll(loadfile);

                    break;

            }

            Write("Restart y/n ");
            char c = char.Parse(ReadLine());

            if (c == 'y')
            {
                finished = false;
            }
            else
            {
                finished = true;
            }

            Clear();
        } while(!finished);
    }
}