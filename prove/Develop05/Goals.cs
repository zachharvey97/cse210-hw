using System;

public abstract class Goals
{
    public string _name{ get; set;}
    private int _points;
    private string _goalDescription;
   

    public Goals()
    {}
    public Goals(string savedString)
    {
        string[] split = savedString.Split("~");
        _name = split[0];
        _goalDescription = split[1];
        _points = int.Parse(split[2]);
    }
    
 
    public string getDescription()
    {
        return _goalDescription;
    }
    public int GetPoints()
    {
        return _points;
    }

    public abstract string Display();
    public abstract int Complete();
    public abstract string SetGoalAttributes();
}