using System;

// Note: I took additional creative steps on this project. While cs files and classes are labelled Lecture, Reception, and Address-- 
// --I took creative liberty to parody The Matrix, because it's funny. Austin is my hometown, and I have good memories of Cabo Bob's.

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("144 Main St", "New York", "NY", "USA");
        Event lecture = new Lecture("Miraculous Event", "Neo flies from New York to Dallas to kick Agents Smith's butt.", new DateTime(2024, 8, 15), "10:00 AM", address1, "Morpheus", 100);

        Address address2 = new Address("960 Lois LN", "Dallas", "TX", "USA");
        Event reception = new Reception("Fighting Event", "Neo kicks Agent Smith's butt", new DateTime(2024, 9, 10), "6:00 PM", address2, "neo@theone.com");

        Address address3 = new Address("Cabo Bobs", "Austin", "TX", "USA");
        Event outdoorGathering = new OutdoorGathering("", "A party with the best burritos in town.", new DateTime(2024, 7, 20), "12:00 PM", address3, "Sunny");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}