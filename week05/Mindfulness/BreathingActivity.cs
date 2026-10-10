using System;
using System.Threading;

using System.Xml;

public class BreathingActivity : Activity
{



  public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")

  {
  }

  public void Run()
  {
    DisplayStartingMessage();
    Console.WriteLine("Get Ready....");
    ShowSpinner(5);
    int sessionTime = -1;

    sessionTime = 0;
    while (sessionTime < _duration)

    {

      Console.WriteLine("Breathe in...");
      ShowBalloon();
      //ShowCountDown(4);
      Thread.Sleep(1000);
      Console.WriteLine("Now breathe out...");
      ShowCountDown(6);
      Thread.Sleep(1000);

      sessionTime = sessionTime + 10;

    }
    DisplayEndingMessage();
    Console.WriteLine("Well Done!!");
    //ShowSpinner(5);
  }


  public void ShowBalloon()
  {
    int[] sizes = { 1, 5, 9, 12, 14, 15, 16 };
    foreach (int size in sizes)
    {
      Console.Write("\r(" + new string('*', size) + ")");
      Thread.Sleep(500);
    }
    Console.WriteLine();
  }





}

