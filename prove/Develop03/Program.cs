using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        bool quit = false;
        string verse = "Trust in the Lord with all thine heart and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture s = new Scripture();
        s.parseScripture(verse);
        //Display original scripture

        while (quit == false){
            //Display with hidden
            s.Scrip();
            Console.WriteLine("\nHit Enter to continue or type quit to exit the program:");
            input = Console.ReadLine();
            if (input == "quit"){
                quit = true;
            }
            else{
                quit = s.isFinished();
                if (quit != true){
                s.setVisibility();
                }
            }
            Console.Clear();
        }
    }
}