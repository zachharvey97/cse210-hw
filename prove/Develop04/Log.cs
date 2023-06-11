using System;

public class Log
{
    private int _breathLog;
    private int _reflectLog;
    private int _listLog;


    public void Display()
    {
        int breath = getBreathLog();
        int reflect = getReflectLog();
        int list = getListLog();

        Console.Clear();
        Console.WriteLine($"Log of activities:\n Breathing:{breath}\n Reflection:{reflect}\n Listing:{list}");
        Console.ReadLine();
    }

    public void addBreathLog()
    {
        _breathLog++;
    }
    public void addReflectLog()
    {
        _reflectLog++;
    }
    public void addListLog()
    {
        _listLog++;
    }

    public int getBreathLog()
    {
        return _breathLog;
    }
    public int getReflectLog()
    {
        return _reflectLog;
    }
    public int getListLog()
    {
        return _listLog;
    }
}