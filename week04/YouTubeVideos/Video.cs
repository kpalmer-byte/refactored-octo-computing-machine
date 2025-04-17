using System;
public class Video
{
    public string _title;
    public string _author;
    public int _videoLength;
    public int _numberOfComments;
    public List<Comments> _comments;

    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
        _comments = new List<Comments>();
        _numberOfComments = 0;
    }

    public void AddComment(Comments comment)
    {
        _comments.Add(comment);
        _numberOfComments = _comments.Count;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length in seconds: {_videoLength}");
        Console.WriteLine($"Number of Comments: {_numberOfComments}");

        foreach (Comments comment in _comments)
        {
            comment.Display();
            Console.WriteLine();
        }
    }

}