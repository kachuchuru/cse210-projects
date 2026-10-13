
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;

    private int _bonus;


    public ChecklistGoal(string name, string description, string points,int target, int bonus): base ("name", "description", "points")
    {
        
        _target = target;
        _bonus = bonus;

    }
    public override void RecordEvent()
    {
        
    }
    
    public override bool IsComplete()
    {
        return true;
    }

    public string GetDetailsString()
{
    return "";
}
    public override string GetStringRepresentation()
    {
        return "";
    }


}

