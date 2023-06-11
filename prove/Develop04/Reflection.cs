using System;

public class Reflection : Activity
{
    private string _prompt;
    private string _reflection;
    
    public Reflection(string activityTitle, string activityDescription) : base(activityTitle, activityDescription)
    {
        base.setActivityTitle(activityTitle);
        base.setActivityDescription(activityDescription);
    }

    public void reflect()
    {
        string prompt;
        string reflection;

        base.displayStartMessage();

        PromptList();
        prompt = getPrompt();
        
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n --- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        DateTime futureTime = base.futureTime();
        DateTime currentTime = DateTime.Now;

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.\nYou may begin in: ");
        base.countdownAnimation(5);

        Console.Clear();
        while(currentTime < futureTime)
        {
            ReflectionList();
            reflection = getReflection();

            Console.WriteLine($">{reflection}");
            base.countdownAnimation(10);

            currentTime = DateTime.Now;
        }

        base.displayEndMessage();
    }

    public void setPrompt(string prompt)
    {
        _prompt = prompt;
    }
    public string getPrompt()
    {
        return _prompt;
    }
    public void setReflcetion(string reflection)
    {
        _reflection = reflection;
    }
    public string getReflection()
    {
        return _reflection;
    }

    public void PromptList()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        Random rnd = new Random();
        int i = rnd.Next(4);
        string prompt = prompts[i];
        setPrompt(prompt);
    }

    public void ReflectionList()
    {
        List<string> reflections = new List<string>();
        reflections.Add("Why was this experience meaningful to you?");
        reflections.Add("Have you ever done anything like this before?");
        reflections.Add("How did you get started?");
        reflections.Add("How did you feel when it was complete?");
        reflections.Add("What made this time different than other times when you were not as successful?");
        reflections.Add("What is your favorite thing about this experience?");
        reflections.Add("What could you learn from this experience that applies to other situations?");
        reflections.Add("What did you learn about yourself through this experience?");
        reflections.Add("How can you keep this experience in mind in the future?");

        Random rnd = new Random();
        int i = rnd.Next(9);
        string reflection = reflections[i];
        setReflcetion(reflection);
    }
}