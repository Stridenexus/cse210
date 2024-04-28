//Caedmon Barry, 4/27/2024, prep 2

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string inGrade = Console.ReadLine();
        int numGrade = int.Parse(inGrade);

        string grade = "";

        if (numGrade >= 90 && numGrade <= 100)
        {
            grade = "A";
        }
        else if (numGrade >= 80 && numGrade < 90)
        {
            grade = "B";
        }
        else if (numGrade >= 70 && numGrade < 80)
        {
            grade = "C";
        }
        else if (numGrade >= 60 && numGrade < 70)
        {
            grade = "D";
        }
        else if (numGrade >= 0 && numGrade < 60)
        {
            grade = "F";
        }
        else
        {
            grade = "invalid. Please enter a valid percentage";
        }

        Console.WriteLine($"Your grade is {grade}.");

        if (grade == "A" || grade == "B" || grade == "C")
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else if (grade == "D" || grade == "F")
        {
            Console.WriteLine("Congratulations, you failed! Better luck next time! You got this!");
        }
        else if (grade == "invalid. Please enter a valid percentage")
        {
            Console.WriteLine("Terminating program. Please restart.");
        }
    }
}