using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;


public abstract class Goal
{
    private string _shortName;

    private string _desription;

    private string _points;

    public Goal(string name, string description,string points)
    {
        _shortName = name;
        _desription = description;
        _points = points;


    }
    public abstract void RecordEvent();
    

    public abstract bool IsComplete();
    
    public string GetDetailString()
    {
       return $"_shortName _desription _points";
    }


    public abstract string GetStringRepresentation();


    }

