using System;
using System.IO;

public class GoalData
{
    private List<Goals> allGoals = new List<Goals>();
    private string savedString;
    private int _score;

    public int getScore()
    {
        int score = _score;
        return score;
    }
    public void AddGoal(Goals goal)
    {
        allGoals.Add(goal);
    }
    public int ListNumber()
    {
        int number  = allGoals.Count;
        return number;
    }

    public List<string> GetGoalListing()
    {
        List<string> options = new List<string>();
        foreach(Goals goal in allGoals)
        {
            options.Add(goal._name);
        }
        return options;
    } 
    public void DisplayGoals()
    {
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("No goals have been created or loaded.");
        }
        Console.WriteLine("The goals are:");
        foreach (Goals goal in allGoals)
        {
            savedString = goal.Display();
            Console.WriteLine($"{allGoals.IndexOf(goal) + 1}. {savedString}");
        }
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue:");
        Console.ReadLine();
    }

    public void completeGoal(int goalNumber)
    {
        int points = allGoals[(goalNumber-1)].Complete();
        _score += points;
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Console.WriteLine($"You now have {_score} points.");
        Console.WriteLine("Press Enter to Continue:");
        Console.ReadLine();
    }

    public void CreateGoal()
    {
        int type = 0;
        GoalData data = new GoalData();
        Console.WriteLine("The types of goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
        Console.WriteLine("What type of goal would you like to create? ");
        type = Convert.ToInt32(Console.ReadLine());
        switch(type)
        {
            case 1: 
                savedString = SetSavedString();
                allGoals.Add(new Simple(savedString, false));
                break;
            case 2:
                savedString = SetSavedString();
                allGoals.Add(new Eternal(savedString));
                break;
            case 3:
                savedString = SetSavedString();
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                int timesToComplete = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                allGoals.Add(new Checklist(savedString, false, bonus, 0, timesToComplete));
                break;
        }
    }

    private string SetSavedString()
    {
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine("How many points are associated with this goal? ");
        string points = Console.ReadLine();
        
        string savedString = $"{name}~{description}~{points}";
        return savedString;
    }

    public void SaveData()
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "goals.txt");
        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
        using (StreamWriter streamWriter = new StreamWriter(fileStream))
        {
            streamWriter.WriteLine(_score);
            
            foreach (Goals goal in allGoals)
            {
                
                    string line = goal.SetGoalAttributes();
                    streamWriter.WriteLine(line);
            }
        }

        Console.WriteLine("Goals and score saved to file.");
        Console.WriteLine("Press Enter to continue:");
        Console.ReadLine();
    }

    public void LoadData()
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "goals.txt");
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        using (StreamReader streamReader = new StreamReader(fileStream))
        {
            int totalScore = int.Parse(streamReader.ReadLine());
            _score = totalScore;

            string line;
            while((line = streamReader.ReadLine()) != null)
            {
                string[] split = line.Split("|");
                string type = split[0];
                string savedGoal = split[1];

                if(type == "Simple")
                {
                    string completion = split[2];
                    bool completed = Convert.ToBoolean(completion);
                    
                    allGoals.Add(new Simple(savedGoal, completed));
                }
                else if(type == "Eternal")
                {
                    allGoals.Add(new Eternal(savedGoal));
                }
                else if (type == "Checklist")
                {
                    string completion = split[2];
                    bool completed = Convert.ToBoolean(completion);
                    int bonus = int.Parse(split[3]);
                    int timesCompleted = int.Parse(split[4]);
                    int timesTotal = int.Parse(split[5]);
                    
                    allGoals.Add(new Checklist(savedGoal, completed, bonus, timesCompleted, timesTotal));
                }
            }
        }
        Console.WriteLine("Your goals and score have been loaded in.");
        Console.WriteLine("Press Enter to continue:");
        Console.ReadLine();
    }

    public string Level()
    {
        string level;
        if (_score == 0)
        {
            level = "Beginner";
            return level;
        }
        else
        {
            double lvl = (_score/250);
            lvl = Math.Ceiling(lvl);
            level = lvl.ToString();
            return level;
        }
    }
}