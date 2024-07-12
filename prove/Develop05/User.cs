using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Channels;

public class User
{
    private List<Bonus> _bonuses;

    public void AwardBonus(Bonus bonus)
    {
        _bonuses.Add(bonus);
        Console.WriteLine($"Congratulations! You've earned a bonus of {bonus.Name} (+{bonus.Points} points)");
    }

    public List<Goal> _goals;
    string _filename;
    private int _totalScore;

    public User(string filename)
    {
        _goals = new List<Goal>();
        _filename = filename;
        _bonuses = new List<Bonus>();
        if (File.Exists(_filename))
        {
            ReadFromFile();
        }
    }

    public void CompleteGoal()
    {
        Console.WriteLine("Select the goal you wish to check off:");
        DisplayGoals();
        Console.Write("Goal: ");

        int input;
        do
        {
            input = int.Parse(Console.ReadLine());
        }
        while (!Enumerable.Range(1, _goals.Count).Contains(input));

        Goal completedGoal = _goals[input - 1];

        completedGoal.Complete();

        int pointsEarned = completedGoal.CalculateScore();

        Console.WriteLine($"You earned {pointsEarned} points!");

        if (UserIsEligibleForBonus())
        {
            AwardBonusForCompletedGoals();
        }
    }

    private bool UserIsEligibleForBonus()
    {
        return _goals.Count(g => g.IsCompleted()) >= 5;
    }

    private void AwardBonusForCompletedGoals()
    {
        _totalScore += 100;
        Console.WriteLine("Congratulations! You've completed 5 goals and earned a bonus of 100 points!");
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");

        string input;

        do
        {
            Console.Write("Which type of goal do you wish to create? ");
            input = Console.ReadLine();
        } while (!new List<String>() { "1", "2", "3" }.Contains(input));

        Console.WriteLine();
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine().Replace("|", "").Trim();
        Console.Write("What is a short desciprtion of it? ");
        string description = Console.ReadLine().Replace("|", "").Trim();
        Console.WriteLine("What are the amount of points for this goal? ");
        int pointsPer = int.Parse(Console.ReadLine());

        switch (input)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, pointsPer));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, pointsPer));
                break;
            case "3":
                Console.WriteLine("How many times does this need to be accolmplished for a bonus? ");
                int timesToComplete = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, pointsPer, timesToComplete));
                break;
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($" {i + 1}. {_goals[i].GetInfo()}");
        }
        Console.WriteLine();
    }

    public int GetTotalScore()
    {
        return _goals.Aggregate(0, (total, current) => total + current.CalculateScore());
    }

    private void ReadFromFile()
    {
        foreach (string Line in File.ReadLines(_filename))
        {
            string[] contents = Line.Split("|");

            switch (contents[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(contents[1], contents[2], int.Parse(contents[3]), !(contents[4]=="0")));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(contents[1], contents[2], int.Parse(contents[3]), int.Parse(contents[4])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(contents[1], contents[2], int.Parse(contents[3]), int.Parse(contents[4]), int.Parse(contents[5])));
                    break;
                default:
                    Console.WriteLine($"Error, unsupported goal type, '{contents[0]}' specified in the file");
                    break;
            }

        }

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found in file");
        }
    }

    public void WriteToFile()
    {
        using (StreamWriter sw = File.CreateText(_filename))
        {
            foreach (Goal goal in _goals)
            {
                sw.WriteLine(goal.Serialize());
            }
        }
    }
}