using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to do Sudoku", "Sue Doku", 600);
        video1.Comments.Add(new Comment("Alice", "Great explanation!"));
        video1.Comments.Add(new Comment("Bob", "Very helpful, thanks!"));
        video1.Comments.Add(new Comment("Charlie", "I finally get it!"));

        Video video2 = new Video("How to tie a tie", "Tyler Knotts", 900);
        video2.Comments.Add(new Comment("Dave", "This was very informative."));
        video2.Comments.Add(new Comment("Eve", "Nice examples!"));
        video2.Comments.Add(new Comment("Frank", "Loved the clarity in your teaching."));

        Video video3 = new Video("How to train your dragon", "Mike Brown", 720);
        video3.Comments.Add(new Comment("Grace", "Amazing content!"));
        video3.Comments.Add(new Comment("Hank", "I was struggling with the flames. This helped."));
        video3.Comments.Add(new Comment("Ivy", "Subscribing now!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}