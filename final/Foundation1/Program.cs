using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> Videos = new List<Video>();

        Video Video1 = new Video("How to do Sudoku", "Sue Doku", 600);
        Video1.Comments.Add(new Comment("Alice", "Great explanation!"));
        Video1.Comments.Add(new Comment("Bob", "Very helpful, thanks!"));
        Video1.Comments.Add(new Comment("Charlie", "I finally get it!"));

        Video Video2 = new Video("How to tie a tie", "Tyler Knotts", 900);
        Video2.Comments.Add(new Comment("Dave", "This was very informative."));
        Video2.Comments.Add(new Comment("Eve", "Nice examples!"));
        Video2.Comments.Add(new Comment("Frank", "Loved the clarity in your teaching."));

        Video Video3 = new Video("How to train your dragon", "Mike Brown", 720);
        Video3.Comments.Add(new Comment("Grace", "Amazing content!"));
        Video3.Comments.Add(new Comment("Hank", "I was struggling with the flames. This helped."));
        Video3.Comments.Add(new Comment("Ivy", "Subscribing now!"));

        Videos.Add(Video1);
        Videos.Add(Video2);
        Videos.Add(Video3);

        foreach (var Video in Videos)
        {
            Console.WriteLine($"Title: {Video.Title}");
            Console.WriteLine($"Author: {Video.Author}");
            Console.WriteLine($"Length: {Video.Length} seconds");
            Console.WriteLine($"Number of Comments: {Video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var Comment in Video.Comments)
            {
                Console.WriteLine($"- {Comment.Name}: {Comment.Text}");
            }
            Console.WriteLine();
        }
    }
}