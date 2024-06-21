using static System.Console;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine(GetEntry());
    }
    public string GetEntry()
    {
        return $"Date: {_date}, {_promptText}:\n{_entryText}";
    }
    public void SetEntry(string date, string prompt, string entry)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entry;
    }
    public void InputEntry()
    {
        PromptGenerator prompt = new PromptGenerator();
        string promptResult = prompt.GetRandomPrompt();
        WriteLine(promptResult);
        string inEntry = ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        SetEntry(dateText, promptResult, inEntry);
    }
}