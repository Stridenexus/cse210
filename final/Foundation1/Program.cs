using System;

public class Program
{
    public static void Main()
    {
        // Create some comments
        Comment comment1 = new Comment("Jack", "Great video!");
        Comment comment2 = new Comment("Grace", "Soooooo cute.");
        Comment comment3 = new Comment("Trinity", "Aww, cute little bean toes!");

        // Create videos and add comments
        Video video1 = new Video("My Cat Is Fluffy", "Dewpiepie", 600);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("My Computer Build", "Agent Smith", 1200);
        video2.AddComment(new Comment("Trinity", "Awesome content, but hands off my Neo!"));
        video2.AddComment(new Comment("Jason", "Very helpful, thanks!"));
        video2.AddComment(new Comment("Alex", "You are the real One!!"));

        Video video3 = new Video("Monkey Flings Dirt At Zoo Keeper", "Jake Jackson", 900);
        video3.AddComment(new Comment("Dominique", "I've never laughed so hard in my life!"));
        video3.AddComment(new Comment("Macy", "Bad monkey... Haha!"));
        video3.AddComment(new Comment("Orian", "Turns out, monkeys like to throw things too! Lolz!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}
