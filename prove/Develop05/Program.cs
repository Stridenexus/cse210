using System;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        User user = new User("goals.txt");
        string input = "";

        do
        {
            Console.WriteLine($"You have {user.GetTotalScore()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Record Event");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Save Goals");
            Console.WriteLine(" 6. Quit");

            Console.Write("Select Option: ");
            input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    user.CreateGoal();
                    break;
                case "2":
                    user.DisplayGoals();
                    break;
                case "3":
                    user.CompleteGoal();
                    break;
                case "4":
                    // Console.Write("Enter the filename to load goals from: ");
                    // string filename = Console.ReadLine();
                    string filename = "goals.txt";
                    List<Goal> goalList = Goal.LoadFromTextFile(filename);
                    user._goals = goalList;
                    if (goalList.Count != 0)
                    {
                        Console.WriteLine("Goals loaded successfully.");
                    }
                    break;
                case "5":
                    // Console.WriteLine("Please select a file name to save goals: ");
                    // string fileName = Console.ReadLine();
                    user.WriteToFile();
                    break;
            }
        } while (new List<String>() { "1", "2", "3", "4", "5" }.Contains(input));

        user.WriteToFile();
    }
}