using System;

public class RecordEvent
{
    // private List<string> _options = new List<string>();
    
    // public void Options(string option)
    // {
    //     _options.Add(option);
    // }

    public int RecordEventMenu(List<string> options)
    {
        Console.WriteLine("The goals are:");
        foreach (string option in options)
        {
            Console.WriteLine($"{options.IndexOf(option) + 1}. {option}");
        }
        Console.WriteLine("Which goal did you accomplish?");
        int i = Convert.ToInt32(Console.ReadLine());
        return i;
    }
}
