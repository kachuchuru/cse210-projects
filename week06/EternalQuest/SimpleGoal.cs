
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
    private bool _IsComplete;


    public SimpleGoal(): base ("name", "description","points")
    {
        
    }
    public override void RecordEvent()
    {
        
    }
    
    public override bool IsComplete()
    {
        return true;
    }



    public override string GetStringRepresentation()
    {
        return "";
    }


}

