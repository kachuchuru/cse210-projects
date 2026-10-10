using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private Random _random = new Random();
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are the people that you appreciate?","What are person strength of yours?", "Who are people you helped this week?", "When have felt the Holy Ghost this month?","Who are some of your personal heroes"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area")
    {

    }


    public void Run()
    {
        {
            DisplayStartingMessage();
            Console.WriteLine("Get Ready....");
            ShowSpinner(2);
            Console.WriteLine("List as many responses you can to the following prompt:");

            string prompt = GetRandomPrompt();
            Console.WriteLine($"---{prompt}----");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You may begin:");
            ShowSpinner(2);
            Thread.Sleep(500);
            List<string> responses = GetListFromUser();
            Console.WriteLine($"You listed {responses.Count} items");
            DisplayEndingMessage();
            Console.WriteLine("Well Done!!");
            //ShowSpinner(2);
        }
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {

        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("");
            string response = Console.ReadLine();


            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }

        }

        return responses;

    }
}