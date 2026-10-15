using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Security.Cryptography;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager(List<Goal> goals, int score)
    {

        _goals = goals;
        _score = score;

    }

    public void Start()
    {

    }
    public int GetScore()
    {
        return _score;
    }
    public void DisplayPlayerInformation()
    {

    }
    public void ListGoalNames()
    {

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{_goals[i].GetDetailString()}");
        }
    }
    public void GoalDetails()
    {

    }

    public void CreateGoal()
    {

        Console.WriteLine("The type of goals are:");
        Console.WriteLine("1. Simple goals");
        Console.WriteLine("2. Eternal goals");
        Console.WriteLine("3. Checklist Goals");

        Console.Write("Which type of a goal would you like to create:?");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal?:");
        string name = Console.ReadLine();

        Console.Write("What is the short description of it?:");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points allocated to this goal?:");
        int points = int.Parse(Console.ReadLine());

        Goal goal;

        if (choice == "1")

        {
            goal = new SimpleGoal(name, description, points);
        }

        else if (choice == "2")
        {
            goal = new EternalGoal(name, description, points);
        }

        else if (choice == "3")
        {
            Console.Write("How many times does this goal needs to be accomplished for a bonus:?");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it?:");
            int bonus = int.Parse(Console.ReadLine());

            goal = new ChecklistGoal(name, description, points, bonus, target);

        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter 1,2,or 3");
            return;
        }
        _goals.Add(goal);
    }

    public void RecordEvent()
    {

        Console.WriteLine("The goals are");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{_goals[i].GetDetailString()}");

        }

        if (_goals.Count == 0)

        {
            Console.WriteLine("There are no goals to record");
            return;
        }

        Console.Write("Which goal did you complete:?");
        if (!int.TryParse(Console.ReadLine(), out int choice) ||
        choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid goal selection");
            return;
        }
        Goal goal = _goals[choice - 1];
        if (goal is SimpleGoal && goal.IsComplete())
        {
            Console.WriteLine("This goal has already been completed");
            return;
        }


        if (goal is ChecklistGoal && goal.IsComplete())
        {
            Console.WriteLine("This goal has already been completed");
            return;

        }
        goal.RecordEvent();
        int pointsEarned = goal.GetPoints();
        if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
        {
            pointsEarned += checklistGoal.GetBonus();
        }
        _score += pointsEarned;

        Console.WriteLine($" Conguratulations! You have earned {pointsEarned}points");
        Console.WriteLine($" You now have {_score}points");

    }



    public void SaveGoals()
    {
        Console.Write("What is the filename?:");
        string filename = (Console.ReadLine());
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());

            }
        }
        Console.WriteLine("Goals and scores saved succesfully");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename?:");
        string filename = (Console.ReadLine());
        if (!File.Exists(filename))
        {
            Console.WriteLine("File notfound");
            return;
        }
        string[] lines = File.ReadAllLines(filename);
        if (lines.Length == 0)
        {
            Console.WriteLine("The file is empty");
            return;
        }
        _score = int.Parse(lines[0]);
        _goals.Clear();
        for (int i = 1; i < lines.Length; i++)

        {
            string[] parts = lines[i].Split(',');
            Goal goal = null;
            if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                simpleGoal.SetComplete(isComplete);
                goal = simpleGoal;
            }
            if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                goal = new EternalGoal(name, description, points);

            }

            if (parts[0] == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);

                ChecklistGoal checklistGoal =
        new ChecklistGoal(name, description, points, bonus, target);

                checklistGoal.SetAmountCompleted(amountCompleted);
                goal = checklistGoal;

            }
            if (goal != null)
            {
                _goals.Add(goal);
            }
        }
    }
}

