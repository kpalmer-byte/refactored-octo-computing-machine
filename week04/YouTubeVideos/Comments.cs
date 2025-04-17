using System;
public class Comments
{
    private string _author;
    private string _text;

    public Comments(string author, string text)
    {
        _author = author;
        _text = text;
    }
    public void Display()
    {
        Console.WriteLine($"{_author}");
        Console.WriteLine($"{_text}");
    }
}