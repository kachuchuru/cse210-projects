

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Activity

{
    private string _name;

    private string _desription;

    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _desription= description;
        _duration = duration;

    } 
    public void DisplayStartingMessage()
    {
        
    }

    public void DisplayEndingMessage()
    {
        
    }
    public int ShowSpinner()
    {
        return (_duration); 
    }

    public int ShowCountDown()
    {
        return (_duration);
    }
}

