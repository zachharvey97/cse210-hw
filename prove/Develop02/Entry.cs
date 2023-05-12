using System;

//show
public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;
    public void Display()
    {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_prompt} \nEntry: {_entry}");
    }
}
