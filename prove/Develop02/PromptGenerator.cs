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
        strings.Add ("What is your favorite hobby?");
        strings.Add ("What is your favorite food?");
        strings.Add ("Which came first the chicken or the egg?");
        int ent = rand.Next(strings.Count);
        string result = strings [ent];
        return result;
    }
}