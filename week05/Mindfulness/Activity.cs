

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Activity

{
    protected string _name;

    protected string _desription;

    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _desription = description;


    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_desription);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your session to take? ");
        _duration = int.Parse(Console.ReadLine());

    }

    public void DisplayEndingMessage()
    {

        Console.WriteLine("Well done!!");
        ShowSpinner(2);
        Console.WriteLine($" You have completed another {_duration}seconds of {_name}");
        ShowSpinner(2);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        DateTime startTime = DateTime.Now;
        int i = 0;
        while ((DateTime.Now - startTime).TotalSeconds < seconds)
        {
            string symbol = animation[i];
            Console.Write(symbol);
            Thread.Sleep(500);
            Console.Write("\b");
            i++;
            if (i >= animation.Count)
            {
                i = 0;
            }

        }
    }

    public void ShowCountDown(int seconds)
    {

        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

}