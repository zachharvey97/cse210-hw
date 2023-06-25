using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        // string savedString;
        GoalData data = new GoalData();
        while (option != 6)
        {
            Console.Clear();
            Console.WriteLine($"Level:{data.Level()} EXP:{data.getScore()}\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\nSelect a choice from the menu: ");
            option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1: 
                    data.CreateGoal();
                    break;
                case 2: 
                    data.DisplayGoals();
                    break;
                case 3:
                    data.SaveData(); 
                    break;
                case 4: 
                    data.LoadData();
                    break;
                case 5:
                    List<string> options = data.GetGoalListing();
                    if (options.Count != 0)
                    {
                    RecordEvent record = new RecordEvent();
                    int i = record.RecordEventMenu(options);
                    data.completeGoal(i);
                    }
                    else
                    {
                        Console.WriteLine("No goals have been created or loaded.");
                    }
                    break;
                case 6: 
                    break;
            }
        }
    }
}
