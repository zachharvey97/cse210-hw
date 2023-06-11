using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        string title;
        string description;

        Log log = new Log();

        while (option != 5)
        {
            Console.Clear();
            Console.WriteLine("Menu options:\n 1.Start breathing activity\n 2.Start reflecting activity\n 3.Start listing activity\n 4.Log\n 5.Quit\nSelect a choice from the menu: ");
            option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    title = "Breathing Activity";
                    description = "help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
                    
                    Breathing breath = new Breathing(title, description);
                    breath.Breathe();
                    log.addBreathLog();
                    break;

                case 2:
                    title = "Reflecting Activity";
                    description = "this activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    
                    Reflection reflecting = new Reflection(title, description);
                    reflecting.reflect();
                    log.addReflectLog();
                    break;

                case 3:
                    title = "Listing Activity";
                    description = "this activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

                    Listing listing = new Listing(title, description);
                    listing.List();
                    log.addListLog();
                    break;

                case 4:
                    log.Display();
                    break;

                case 5:
                    break;

                default:
                    Console.WriteLine("Sorry, please choose a menu option.");
                    break;
            }
        }
    }
}