using System;
// using System.Collections;

public class GetPrompt
{
    public string randomPrompt()
{  
    // ArrayList prompts = new ArrayList();
    // prompts.Add("What was the most interesting thing I saw or heard today?"); 
    // prompts.Add("What did I learn today?"); 
    // prompts.Add("What is the current problem or challenge I am facing?"); 
    // prompts.Add("What is one thing that I have always wanted to create, and what steps can I take to make it a reality?"); 
    // prompts.Add("What was a moment of joy, delight, or contentment today?");  

    List<string> listRange = new List<string>();  
    listRange.Add("What was the most interesting thing I saw or heard today?");  
    listRange.Add("What did I learn today?"); 
    listRange.Add("What is the current problem or challenge I am facing?"); 
    listRange.Add("What is one thing that I have always wanted to create, and what steps can I take to make it a reality?"); 
    listRange.Add("What was a moment of joy, delight, or contentment today?");  

    Random rnd = new Random();
    int j = rnd.Next(5);
    string prompt = listRange[j];
    return prompt;  
} 

    public void haiku(){
        List<string> haikus = new List<string>();
        haikus.Add("\n 'The light of a candle' by Yosa Buson \nThe light of a candle \nIs transferred to another candle - \nspring twilight.");
        haikus.Add("\n'Haiku Ambulance' by Richard Brautigan \nA piece of green pepper \nfell \noff the wooden salad bowl: \nso what?");
        haikus.Add("\n'A World of Dew' by Kobayashi Issa \nThis world of dew \nis a world of dew, \nand yet, and yet.");
        haikus.Add("\n'A Poppy Blooms' by Katsushika Hokusai \nI write, erase, rewrite \nErase again, and then \nA poppy blooms.");
        haikus.Add("\n'In the moonlight' by Yosa Buson \nIn pale moonlight \nthe wisteria's scent \ncomes from far away.");
        Random rnd = new Random();
        int h = rnd.Next(5);
        string haiku = haikus[h];
        Console.WriteLine($"{haiku}");
    }

    public void affirmation(){
        List<string> affirmations = new List<string>();
        affirmations.Add("\nGood Job!");
        affirmations.Add("\nGreat Journaling");
        affirmations.Add("\nKeep up the good work!");
        affirmations.Add("\nYou did very well today!");
        affirmations.Add("\nYour on fire!");
        Random rnd = new Random();
        int a = rnd.Next(5);
        string affirmation = affirmations[a];
        Console.WriteLine($"{affirmation}");
    }
}
