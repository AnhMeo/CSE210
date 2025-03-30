using System;
using System.Collections.Generic;

public class Video
{
    public string Title;
    public string Author;
    public int Length;
    public List<Comment> Comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}