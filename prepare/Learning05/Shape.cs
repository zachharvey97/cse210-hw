using System;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public void setColor(string color)
    {
        _color = color;
    }
        public string getColor()
    {
        return _color;
    }
    
    public abstract double GetArea();
}