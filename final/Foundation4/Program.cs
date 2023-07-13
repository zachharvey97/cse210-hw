using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running1 = new Running(new DateTime(2023, 7, 21), 30, 2.5);
        Cycling cycling = new Cycling(new DateTime(2023, 7, 21), 30, 17);
        Swimming swimming = new Swimming(new DateTime(2023, 7, 21), 15, 25);

        activities.Add(running1);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.Summary();
        }
    }
}