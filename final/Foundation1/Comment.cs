using System;

class Comment
{
    public string _commenter {get; private set;}
    public string _comment {get; private set;}

    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }
}