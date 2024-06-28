using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Word word = new Word("Behold");
        Console.WriteLine(word.GetWord());
        Console.WriteLine(word.IsHidden());
        word.Hide();
        Console.WriteLine(word.IsHidden());
        Console.WriteLine(word.GetWord());
    }
}