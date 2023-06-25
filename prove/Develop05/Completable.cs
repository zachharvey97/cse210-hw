using System;

public abstract class Completable : Goals
{
    public bool _isComplete;
   public Completable(string savedString, bool isComplete) : base(savedString)
   {
        _isComplete = isComplete;
   }
}