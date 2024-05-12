//Caedmon Barry, Prep 3, 5/12/2024

using System;
using System.Net;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 100);
        int numTrack = 0;

        while (numTrack != number)
        {
            Write("What is your guess? ");
            string promptGuess = ReadLine();
            int guess = int.Parse(promptGuess);
            numTrack = guess;

            if (numTrack < number)
            {
                WriteLine("Higher. Guess Again!");
            }
            else if (numTrack > number)
            {
                WriteLine("Lower. Guess Again!");
            }
            else
            {
                WriteLine("Correct! Thank you for playing!");
            }
        }
    }
}