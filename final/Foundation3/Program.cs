using System;

class Program
{
    static void Main(string[] args)
    {        
        Address address1 = new Address("570 S 2nd St W", "Rexburg", "ID", "83440");
        Address address2 = new Address("47 Burnt Swamp Rd", "Wrentham", "MA", "02093");
        Address address3 = new Address("10667 S 2275 W", "South Jordan", "UT", "84095");

        Lecture lecture = new Lecture("Time Travel Through Ker Black Holes", "An in-depth look into whether time travel is possible using Ker Black Holes", new DateTime(2023, 7, 24, 16, 30, 0), address1, "Dr.Nakabachi", "Particle Physicist");

        Reception reception = new Reception("Wedding Reception", "Please come to Ken Harvey & Ashleigh Fulwood's wedding Reception", new DateTime(2023, 7, 16, 18, 0, 0), address2, "KenHarvey89@gmail.com");

        Outdoor outdoor = new Outdoor("Barbeque", "4th of July Summer Barbeque", new DateTime(2023, 7, 4, 17, 30, 0), address3, "Partially Cloudy");

        //Lecture
        lecture.StandardDisplay();
        Console.WriteLine();
        lecture.FullDetailsDisplay();
        Console.WriteLine();
        lecture.ShortDisplay();

        Console.WriteLine("******************************");
        
        //Reception
        reception.StandardDisplay();
        Console.WriteLine();
        reception.FullDetailsDisplay();
        Console.WriteLine();
        reception.ShortDisplay();

        Console.WriteLine("*************************");
        
        //Outdoor
        outdoor.StandardDisplay();
        Console.WriteLine();
        outdoor.FullDetailsDisplay();
        Console.WriteLine();
        outdoor.ShortDisplay();
    }
}