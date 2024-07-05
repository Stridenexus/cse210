class ListingActivity : Activity
{
    private string[] Prompts = {
            "What makes you happy in life?",
            "What foods do you like?",
            "What do you like to do on vacation?",
    };
    public ListingActivity(int _duration, string _logFileName) : base(_duration, _logFileName) { }

    public override void Play()
    {
        LoadingAnimation("Here is your meditation prompt: ");
        Log("Please begin listing");

        int _itemsListed = 0;

        Random _random = new Random();
        string _prompt = Prompts[_random.Next(Prompts.Length)];
        Console.WriteLine(_prompt);

        LoadingAnimation("Get Ready");

        DateTime _startTime = DateTime.Now;
        while ((DateTime.Now - _startTime).TotalSeconds < _activityDuration)
        {
            // Console.WriteLine("Press Enter when ready...");
            // Console.ReadLine();
            Console.Write("Enter an item: ");
            Console.ReadLine();
            _itemsListed++;
            // LoadingAnimation();
        }
        Log($"You listen {_itemsListed} items.");
        Log($"Thank you, your listing took {_activityDuration}. Great Job!");
        Console.WriteLine($"You listen {_itemsListed} items.");
        Console.WriteLine($"Thank you, your self reflection took {_activityDuration}. Great Job!");
        LoadingAnimation("Finished");
    }
}