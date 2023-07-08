using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("How to make Gil in FFXIV", "Drakstein", 2345);
        Video v2 = new Video("Relaxing Study Playlist", "StudyKid", 3422342);
        Video v3 = new Video("Turtle Animation", "JoCat", 37);
        
        List<Comment> commentsV1 = new List<Comment>
        {
            new Comment("Skylia", "This is super helpful!"),
            new Comment("Parthel", "Didn't know buying dye was so easy"),
            new Comment("Lestiva", "What's a good way to make Gil with a gatherer?"),
        };

        List<Comment> commentsV2 = new List<Comment>
        {
            new Comment("Matt", "First"),
            new Comment("Emily", "Love the music"),
            new Comment("Oats", "Studying for final wish me luck"),
            new Comment("Mathius", "Goodluck Oats!")
        };

        List<Comment> commentsV3 = new List<Comment>
        {
            new Comment("Gerbo", "Such a cool animation, keep it up!"),
            new Comment("Fijit", "Such a cute turtle!"),
            new Comment("Maxine", "Love it!")
        };

        v1.addComments(commentsV1);
        v2.addComments(commentsV2);
        v3.addComments(commentsV3);

        v1.Display();
        v2.Display();
        v3.Display();
    }
}