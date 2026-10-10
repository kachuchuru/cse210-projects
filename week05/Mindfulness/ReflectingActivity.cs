using System;
using System.Collections.Generic;

using System.Threading;

public class ReflectingActivity : Activity
{

    private Random _random = new Random();
    private List<string> _prompts = new List<string>
    {
    "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless"};
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you done anything like this before?",
        "How did you get started?",
        "How did you feel when it was completed?",
        "What made this time different than other times when you were not as succesful?",
        "What is your favourite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?"};



    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times on your life when you will have shown strength and resilience.This will help you recognize the power you have and how you can use it in other aspects of your life")
    {

    }
    private string GetRandomPrompt()
    {

        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {

        int index = _random.Next(_questions.Count);
        return _questions[index];
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get Ready....");
        ShowSpinner(2);
        Console.WriteLine("Consider the following prompt:");

        string prompt = GetRandomPrompt();
        Console.WriteLine($"---{prompt}----");
        ShowCountDown(3);
        Thread.Sleep(500);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.WriteLine("You may begin:");
        ShowCountDown(2);
        Thread.Sleep(500);
        string question1 = GetRandomQuestion();
        Console.WriteLine($"<<<< {question1}>>>");
        ShowSpinner(10);
        Thread.Sleep(1000);

        string question2 = GetRandomQuestion();
        Console.WriteLine($"<<< {question2}>>>");
        ShowSpinner(10);
        Thread.Sleep(1000);
        DisplayEndingMessage();
        Console.WriteLine("Well Done!!");
        //ShowSpinner(2);
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(_prompts);
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(_questions);
    }
}