class BreathingActivity : Activity
{
    public BreathingActivity(int _duration, string _logFileName) : base(_duration, _logFileName) { }
    
    public override void Play()
    {
        Log("Please start breathing");
        LoadingAnimation("Get Ready");
        DateTime _startTime = DateTime.Now;

        while ((DateTime.Now - _startTime).TotalSeconds < _activityDuration)
        {
            Console.WriteLine("Breath In...");
            LoadingAnimation();
            Console.WriteLine("Breath Out...");
            LoadingAnimation();
        }
        Log($"Thank you, you have been breathing for {_activityDuration}");
        Console.WriteLine($"Thank you, you have been breathing for {_activityDuration}");
        LoadingAnimation("Finished.");
    }
}