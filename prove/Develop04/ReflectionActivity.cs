using System.Text;
class ReflectionActivity : Activity
{
    public ReflectionActivity(int _duration, string _logFileName) : base (_duration, _logFileName) { }

    public override void Play()
    {
        Log("Please Reflect Now.");
        LoadingAnimation("Get Ready");
        Random _random = new Random ();
        DateTime _startTime = DateTime.Now;
        
        while ((DateTime.Now - _startTime).TotalSeconds < _activityDuration)
        {
            string [] _reflectionQuestions = {
                "Have you helped anyone today?",
                "Have you help yourself today?",
                "Have you donated money recently?",
                "have you shown love and support to a friend today?"
            };

            Console.WriteLine(_reflectionQuestions[_random.Next(_reflectionQuestions.Length)]);
            LoadingAnimation();
        }

        Log($"Thank you, your self reflection took {_activityDuration}. Great Job!");
        Console.WriteLine($"Thank you, your self reflection took {_activityDuration}. Great Job!");
        LoadingAnimation("Finished");
    }
}