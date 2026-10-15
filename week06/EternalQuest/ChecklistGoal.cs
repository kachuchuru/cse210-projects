
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Runtime;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;

    private int _bonus;


    public ChecklistGoal(string name, string description, int points, int bonus, int target) : base(name, description, points)
    {

        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;

    }
    public override void RecordEvent()
    {
        if (_amountCompleted >= _target)
        {
            return;
        }
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override string GetDetailString()
    {
        string checkbox = IsComplete() ? "[x]" : "[]";
        return $"[Checklist Goal] {checkbox} {_shortName}({_description})---Completed {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }


}

