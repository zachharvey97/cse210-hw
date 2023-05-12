using System;

//show
public class Menu
{
    public int Display(){

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        int UserInput = Convert.ToInt32(Console.ReadLine());
        return UserInput;
    }
}
