
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
    private bool _isComplete;


    public SimpleGoal(string name, string description, int points)
     : base(name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailString()
    {
        string checkbox = _isComplete ? "[x]" : "[]";
        return $"[Simple Goals] S{checkbox}{_shortName}({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_shortName},{_description},{_points},{_isComplete}";
    }
    public void SetComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

}

