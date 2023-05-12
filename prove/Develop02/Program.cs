using System;
using System.IO;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        int menuNumber = 1;
        while(menuNumber == 1)
        {
            //Shows user the menu and gets user input for number.
            Menu display = new Menu();
            int userChoice = display.Display();
            // Loads in Journal Class
            Journal journal = new Journal();
            //Switch to do user's choice from menu
            switch(userChoice)
            {
                case 1:
                    //gets the prompt for an entry
                    GetPrompt getPrompt = new GetPrompt();
                    string prompt = getPrompt.randomPrompt();
                    //gets datetime
                    DateTime currentDate = DateTime.Now;
                    string dateText = currentDate.ToShortDateString();
                    //gets haiku
                    getPrompt.haiku();
                    //entry
                    Console.WriteLine($"\n{prompt}\nWrite here:");
                    string newentry = Console.ReadLine();
                    Entry entry = new Entry();
                    entry._date = dateText;
                    entry._prompt = prompt;
                    entry._entry = newentry;
                    journal.addEntry(entry);
                    entry.Display();
                    getPrompt.affirmation();
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    journal.Load();
                    break;
                case 4:
                    journal.Save();
                    break;
                case 5:
                    Console.WriteLine("\nSee you next time.");
                    menuNumber = 5;
                    break;
                default:
                    Console.WriteLine("Sorry, please choose a menu option.");
                    break;
            }
        }
        
    }
}
