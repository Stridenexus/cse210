using System.ComponentModel;
using System;
using System.IO;

abstract class Activity
{
    // string _message;
    protected int _activityDuration;

    public Activity(int _duration, string _name)
    {
        _activityDuration = _duration;
        Program.logFile = _name;
    }
    public abstract void Play();
    protected void Log(string _message)
    {
        using (StreamWriter writer = new StreamWriter(Program.logFile))
        {
            writer.WriteLine($"{DateTime.Now}, {_message}");
        }
    }
    protected virtual void LoadingAnimation(string _message = " ")
    {
        int mLen = _message.Length;
        string backer = new string('\b',(mLen + 2));
        string eraser = new string(' ',(mLen + 2));
        DateTime futureTime = DateTime.Now.AddSeconds(5);
        while (DateTime.Now < futureTime)
        {
            Console.Write(backer + eraser + backer);
            Console.Write($"{_message} \\");
            System.Threading.Thread.Sleep(500);
            // Console.Clear();
            Console.Write(backer + eraser + backer);
            Console.Write($"{_message} |");
            System.Threading.Thread.Sleep(500);
            // Console.Clear();
            Console.Write(backer + eraser + backer);
            Console.Write($"{_message} /");
            System.Threading.Thread.Sleep(500);
            // Console.Clear();
            Console.Write(backer + eraser + backer);
            Console.Write($"{_message} -");
            System.Threading.Thread.Sleep(500);
            // Console.Clear();
        }
    }
}