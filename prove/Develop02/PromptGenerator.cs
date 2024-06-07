public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        List<string> strings = new List<string>();
        strings.Add ("What did you eat for breakfast?");
        strings.Add ("Were you able to help someone today?");
        strings.Add ("What are you grateful for today?");
        int ent = rand.Next(strings.Count);
        string result = strings [ent];
        return result;
    }
}