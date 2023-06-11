using System;

public class Activity
{
    private string _activityTitle;
    private string _activityDescription;
    private int _activityTime;
    private List<int> _usedPrompts = new List<int>{};

    public Activity(string activityTitle, string activityDescription)
    {
        setActivityTitle(activityTitle);
        setActivityDescription(activityDescription);
    }

    public string getActivityTitle()
    {
        return _activityTitle;
    }
    public void setActivityTitle(string activityTitle)
    {
        _activityTitle = activityTitle;
    }

    public int getActivityTime()
    {
        return _activityTime;
    }
    public void setActivityTime(int activityTime)
    {
        _activityTime = activityTime;
    }
    public DateTime futureTime()
    {
        int seconds = getActivityTime();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        return futureTime;
    }

    public string getActivityDescription()
    {
        return _activityDescription;
    }
    public void setActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }


    public void displayStartMessage()
    {
        string activityTitle = getActivityTitle();
        string activityDescription = getActivityDescription();
        int duration = 0;
        
        Console.Clear();
        Console.WriteLine($"Welcome to the {activityTitle}.\n\nThis activity will help you {activityDescription}\n\nHow long in seconds, would you like for your session? ");
        duration = Convert.ToInt32(Console.ReadLine());
        setActivityTime(duration);
        
        Console.Clear();
        Console.WriteLine("Get ready");

        spinnerAnimation();
    }

    public void displayEndMessage()
    {
        int activityTime = getActivityTime();
        string activityTitle = getActivityTitle();
        Console.WriteLine("\nGreat Job!!");
        spinnerAnimation();
        Console.WriteLine($"\nYou have completed another {activityTime} seconds of the {activityTitle}");
        spinnerAnimation();
    }

    public void spinnerAnimation()
    {
        int spinner = 1;
        for (int i = 8; i > 0; i--)
        {
        //     Console.Write(".");
        //     Thread.Sleep(1000);
        // }
            if (spinner == 5)
            {
                spinner -= 4;
            }
            switch(spinner)
            {
                case 1:
                    Console.Write("/");
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    break;
                case 2:
                    Console.Write("-");
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    break;
                case 3:
                    Console.Write("\\");
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    break;
                case 4:
                    Console.Write("|");
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    break;
            }
            spinner++;
        }
    }

    public void countdownAnimation(int countdown)
    {
        for (int i = countdown; i > 0; i--)
            {
                if(i>9)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b\b  \b\b");
                }
                
                else
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
            }
    }
}