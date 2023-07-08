using System;

class Video
{
    private string _Title {get; set;}
    private string _Author {get; set;}
    private int _Length {get; set;}
    private List<Comment> _Comments {get; set;}

    public Video(){}
    public Video(string title, string author, int length)
    {
        _Title = title;
        _Author = author;
        _Length = length;
        _Comments = new List<Comment>();
    }

    public void addComments(List<Comment> comments)
    {
        _Comments.AddRange(comments);
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"The video's title is {_Title}");
        Console.WriteLine($"The Video's author is {_Author}");
        Console.WriteLine($"The Video's length is {_Length} seconds long");
        Console.WriteLine($"The Video has {_Comments.Count} comments");
        foreach (Comment comment in _Comments)
        {
            Console.WriteLine($"\n {comment._commenter} says {comment._comment}");
            
        }
        
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
}