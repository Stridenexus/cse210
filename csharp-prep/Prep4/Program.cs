//Caedmon Barry, Prep 4, 5/12/2024

using System;
using System.Collections.Generic;
using System.Globalization;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int numTrack = -1;

        while (numTrack != 0)
        {
            Write("Please add a number. Type 0 When finished. ");
            string numPrompt = ReadLine();
            int number = int.Parse(numPrompt);
            numTrack = number;
            if (numTrack != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        WriteLine($"The sum is: {sum}.");

        float avg = ((float) sum / numbers.Count);

        WriteLine($"The average is {avg}.");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        WriteLine($"The max is: {max}.");

    }
}