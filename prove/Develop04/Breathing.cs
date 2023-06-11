using System;

public class Breathing : Activity
{
    public Breathing(string activityTitle, string activityDescription) : base(activityTitle, activityDescription)
    {
        base.setActivityTitle(activityTitle);
        base.setActivityDescription(activityDescription);
    }

    public void Breathe()
    {        
        DateTime futureTime = base.futureTime();
        DateTime currentTime = DateTime.Now;
        
        while(currentTime < futureTime)
        {
            Console.WriteLine("\nBreathe in...");
            base.countdownAnimation(4);

            Console.WriteLine("Breathe out...");
            base.countdownAnimation(6);

            currentTime = DateTime.Now;
        }

        base.displayEndMessage();
    }
}