using System;

public class Listing : Activity
{
    private string _prompt;
    private int _itemsListed;

    public Listing(string activityTitle, string activityDescription) : base(activityTitle, activityDescription)
    {
        base.setActivityTitle(activityTitle);
        base.setActivityDescription(activityDescription);
    }

    public void List()
    {
        string response;

        PromptList();
        base.displayStartMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");

        string prompt = getPrompt();
        Console.WriteLine($" --- {prompt} ---");
        Console.WriteLine("You may begin in:");
        base.countdownAnimation(10);

        DateTime futureTime = base.futureTime();
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            //Having an issue where something is causing my lines to write strangely. For example this ">" writes on a new line each loop through when it shouldn't
            //I can't figure out the cause but thought to leave a note if you might have an idea as to what the cause is.  
            Console.Write(">");
            response = Console.ReadLine();
            
            if (response != "")
            {
                addItemListed();
            }

            currentTime = DateTime.Now;
        }

        int items = getItemListed();
        Console.WriteLine($"You listed {items} items!");

        base.displayEndMessage();
    }

    public void addItemListed()
    {
        _itemsListed += 1;
    }
    public int getItemListed()
    {
        return _itemsListed;
    }
    public void setPrompt(string prompt)
    {
        _prompt = prompt;
    }
    public string getPrompt()
    {
        return _prompt;
    }

    public void PromptList()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");

        Random rnd = new Random();
        int i = rnd.Next(5);
        string prompt = prompts[i];
        setPrompt(prompt);
    }
}