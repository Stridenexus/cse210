using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static string logFile = "Meditation.txt";
    static int PromptForDuration()
    {
        Console.WriteLine("How long would you like to meditate?");
        return int.Parse(Console.ReadLine());
    }
    static void Main(string[] args)
    {
        string menuText = @"
Please choose from the list.
1. Breathing Activity
2. Reflection Activity
3. Listing Activity
4. Quit
Choose one: ";
        bool _quit = false;
        while (!_quit)
        {
            Console.Write(menuText);
            int option = int.Parse(Console.ReadLine());

            int duration;

            switch (option)
            {
                case 1:
                    duration = PromptForDuration();
                    BreathingActivity breathingActivity = new BreathingActivity(duration, logFile);
                    breathingActivity.Play();

                    break;
                case 2:
                    duration = PromptForDuration();
                    ReflectionActivity reflectionActivity = new ReflectionActivity(duration, logFile);
                    reflectionActivity.Play();

                    break;
                case 3:
                    duration = PromptForDuration();
                    ListingActivity listingActivity = new ListingActivity(duration, logFile);
                    listingActivity.Play();

                    break;
                case 4:
                    Console.WriteLine("Quitting");
                    _quit = true;

                    break;

            }
        }
    }
}