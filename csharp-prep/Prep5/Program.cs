//Caedmon Barry, Prep 5, 5/12/2024

using System;
using System.Reflection.Metadata.Ecma335;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int SqNum = SquareNumber(favNum);
        WriteLine($"Hello agent {name}, the square of your number is {SqNum}!!!");
    }

    static void DisplayWelcome()
    {
        WriteLine("Welcome to the Program!!!");
    }

    static string PromptUserName()
    {
        Write("Please enter your name: ");
        string name = ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Write("Please enter your favorite number: ");
        string favoriteNumber = ReadLine();
        int number = int.Parse(favoriteNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = (number * number);
        return square;
    }
}