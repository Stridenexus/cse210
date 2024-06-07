using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt = new PromptGenerator();
        string promptResult = prompt.GetRandomPrompt();
        WriteLine(promptResult);

        Entry entry = new Entry();
        entry.Display();
    }
}