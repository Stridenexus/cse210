using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        Reference reference = new Reference("Revelation",21,6,7);
        Scripture scripture = new Scripture();
        reference.GetReference();
        WriteLine(scripture.GetScriptureDisplay());

        do
        {
            
            Write("Press q to quit: ");
            char c = char.Parse(ReadLine());

            if (c == 'q')
            {
                quit = true;
            }
            else
            {
                quit = false;
            }

            Clear();

            reference.GetReference();
            scripture.GetNumber();
            WriteLine(scripture.GetScriptureDisplay());
        }
        while (!quit);
    }
}