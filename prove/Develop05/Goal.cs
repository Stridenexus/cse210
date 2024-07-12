using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.IO;

public abstract class Goal
{
    protected int _pointsPer;
    protected string _description;
    protected bool _isComplete;
    protected string _name;

    public Goal(string name, string description, int pointsPer)
    {
        _pointsPer = pointsPer;
        _description = description;
        _name = name;
    }
    public abstract int CalculateScore();
    public abstract void Complete();
    public abstract string GetInfo();
    public abstract string Serialize();
    public static List<Goal> LoadFromTextFile(string filename)
    {
        List<Goal> loadedGoals = new List<Goal>();
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line into parts using the pipe character as the separator
                    string[] parts = line.Split('|');
                    string goalType = parts[0];

                    // Determine the type of goal based on the goalType
                    switch (goalType)
                    {
                        case "SimpleGoal:":
                            // Extract information from parts

                            // Ensure the line has the correct number of parts
                            if (parts.Length != 5)
                            {
                                Console.WriteLine("Error: Invalid format in the file.");
                                // return null;
                            }
                            string name = parts[1];
                            string description = parts[2];
                            if (!int.TryParse(parts[3], out int pointsPer))
                            {
                                Console.WriteLine("Error: Invalid points per completion information in the file.");
                                // return null;
                            }
                            if (!int.TryParse(parts[4], out int completionStatus))
                            {
                                Console.WriteLine("Error: Invalid completion status information in the file.");
                                // return null;
                            }

                            loadedGoals.Add(new SimpleGoal(name, description, pointsPer, (completionStatus == 1) ? true : false));
                            break;
                        // Add cases for other goal types if needed
                        case "EternalGoal:":
                            // Extract information from parts

                            // Ensure the line has the correct number of parts
                            if (parts.Length != 5)
                            {
                                Console.WriteLine("Error: Invalid format in the file.");
                                // return null;
                            }
                            name = parts[1];
                            description = parts[2];
                            if (!int.TryParse(parts[3], out pointsPer))
                            {
                                Console.WriteLine("Error: Invalid points per completion information in the file.");
                                // return null;
                            }
                            if (!int.TryParse(parts[4], out int timesCompleted))
                            {
                                Console.WriteLine("Error: Invalid number of times completed in the file.");
                                // return null;
                            }

                            loadedGoals.Add(new EternalGoal(name, description, pointsPer, timesCompleted));
                            break;
                        // Add cases for other goal types if needed
                        case "ChecklistGoal:":
                            // Extract information from parts

                            // Ensure the line has the correct number of parts
                            if (parts.Length != 6)
                            {
                                Console.WriteLine("Error: Invalid format in the file.");
                                // return null;
                            }
                            name = parts[1];
                            description = parts[2];
                            if (!int.TryParse(parts[3], out pointsPer))
                            {
                                Console.WriteLine("Error: Invalid points per completion information in the file.");
                                // return null;
                            }
                            if (!int.TryParse(parts[4], out int timesToComplete))
                            {
                                Console.WriteLine("Error: Invalid times to complete in the file.");
                                // return null;
                            }
                            if (!int.TryParse(parts[5], out timesCompleted))
                            {
                                Console.WriteLine("Error: Invalid number of times completed in the file.");
                                // return null;
                            }

                            loadedGoals.Add(new ChecklistGoal(name, description, pointsPer, timesToComplete, timesCompleted));
                            break;
                        default:
                            Console.WriteLine("Error: Unsupported goal type specified in the file.");
                            // return null;
                            break;
                    }
                }

                // Console.WriteLine("Error: No goals found in the file.");
                // return null;
            }
            return loadedGoals;
        }
        catch (IOException)
        {
            Console.WriteLine("Error: Unable to read goal data from the file. Please check the filename and try again.");
            return null;
        }
    }

    public virtual bool IsCompleted()
    {
        return false;
    }
}