using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person(); // Don't pass any information to get the default values
        Person p2 = new Person("Jane", "Doe"); // pass the first and last names
        Person p3 = new Person("Mrs.", "Jane", "Doe"); // pass all three variables
    }
}