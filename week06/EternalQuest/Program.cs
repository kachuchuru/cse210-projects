using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
class Program
{
   static void Main(string[] args)
   {
      List<Goal> goals = new List<Goal>();
      GoalManager myGoalManager = new GoalManager(goals, 0);

      Console.WriteLine($"You have {myGoalManager.GetScore()} points");

      int x = -1;
      while (x != 6)
      {
         Console.WriteLine("\nMenu options:");
         Console.WriteLine("1. Create New goal");
         Console.WriteLine("2. List Goals");
         Console.WriteLine("3. Save Goals");
         Console.WriteLine("4. Load Goals");
         Console.WriteLine("5. Record Event");
         Console.WriteLine("6. Quit");
         Console.Write("Select a choice from the menu: ");

         string userInput = Console.ReadLine();
         x = int.Parse(userInput);


         if (x == 1)
         {
            myGoalManager.CreateGoal();
         }

         else if (x == 2)
         {

            myGoalManager.ListGoalNames();
         }
         else if (x == 3)
         {

            myGoalManager.SaveGoals();
         }
         else if (x == 4)
         {

            myGoalManager.LoadGoals();
         }
         else if (x == 5)
         {

            myGoalManager.RecordEvent();
         }

         else if (x == 6)
         {

            Console.WriteLine("Goodbye!!");
         }
         else
         {
            Console.WriteLine("Invalid choice");
         }

      }




   }
}