using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static List<Goal> Goals = new List<Goal>();
    private static int TotalScore = 0;
    private static string FileName = "goals.txt";
    private static int HighestRankAchieved = -1; // Track the highest rank reached

    static void Main()
    {
        LoadGoals();

        while (true)
        {
            Console.WriteLine("Goal Tracker Menu:");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. View Goals");
            Console.WriteLine("3. Record an Event");
            Console.WriteLine("4. View Total Score");
            Console.WriteLine("5. Delete Goals File");
            Console.WriteLine("6. Save and Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    DisplayGoals();
                    break;
                case "3":
                    RecordGoalEvent();
                    break;
                case "4":
                    Console.WriteLine($"\nTotal Score: {TotalScore} points");
                    break;
                case "5":
                    DeleteGoalsFile();
                    break;
                case "6":
                    SaveGoals();
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("\nChoose Goal Type:");
        Console.WriteLine("1. Simple Goal (One-time)");
        Console.WriteLine("2. Eternal Goal (Repeatable)");
        Console.WriteLine("3. Checklist Goal (Multiple Steps)");
        Console.Write("Enter your choice: ");
        
        string choice = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points for completion: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                Goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                Goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                Goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine("Goal added successfully!");
    }

    private static void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        if (Goals.Count == 0)
        {
            Console.WriteLine("No goals added yet.");
            return;
        }

        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Goals[i].GetStatus()}");
        }
    }

    private static void RecordGoalEvent()
    {
        DisplayGoals();
        if (Goals.Count == 0) return;

        Console.Write("\nEnter goal number to record an event: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < Goals.Count)
        {
            Goals[index].RecordEvent();
            if (Goals[index] is ChecklistGoal checklistGoal && checklistGoal.IsComplete)
            {
                TotalScore += checklistGoal.BonusPoints;
            }
            TotalScore += Goals[index].Points;
            CheckForRankUp();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private static void CheckForRankUp()
    {
        string[] Ranks = { "Iron", "Bronze", "Silver", "Gold", "Platinum", "Emerald", "Ruby", "Diamond" };
        string[] RankColors = { "\u001b[38;5;240m", "\u001b[38;5;130m", "\u001b[38;5;250m", "\u001b[38;5;220m", "\u001b[38;5;33m", "\u001b[38;5;34m", "\u001b[38;5;160m", "\u001b[38;5;201m" }; // ANSI colors for each rank

        int[] RankThresholds = { 0, 100, 250, 625, 1560, 3900, 9750, 24375 }; // Graduated points needed for each rank (2.5X MORE each time)

        int newRank = 0;
        for (int i = 0; i < RankThresholds.Length; i++)
        {
            if (TotalScore >= RankThresholds[i])
                newRank = i;
            else
                break;
        }

        if (newRank > HighestRankAchieved)
        {
            HighestRankAchieved = newRank;
            Console.WriteLine($"Congratulations! You ranked up to {RankColors[newRank]}{Ranks[newRank]}\u001b[0m!");
            SaveGoals(); // Save progress immediately after ranking up 
        }
    }

    private static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(FileName))
        {
            writer.WriteLine(TotalScore); // Save total score 
            writer.WriteLine(HighestRankAchieved); // Save highest rank achieved 

            foreach (Goal goal in Goals)
            {
                writer.WriteLine(goal.ToSaveFormat());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    private static void LoadGoals()
    {
        if (File.Exists(FileName))
        {
            Goals.Clear();
            string[] lines = File.ReadAllLines(FileName);
            TotalScore = int.Parse(lines[0]); // Load total score 
            HighestRankAchieved = int.Parse(lines[1]); // Load highest rank achieved 
            
            for (int i = 2; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');

                string goalType = parts[0];
                string name = parts[1];
                int points = int.Parse(parts[2]);

                if (goalType == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[3]);
                    Goals.Add(new SimpleGoal(name, points, isComplete));
                }
                else if (goalType == "EternalGoal")
                {
                    Goals.Add(new EternalGoal(name, points));
                }
                else if (goalType == "ChecklistGoal")
                {
                    int target = int.Parse(parts[3]);
                    int timesCompleted = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    Goals.Add(new ChecklistGoal(name, points, target, bonus, timesCompleted));
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

    private static void DeleteGoalsFile()
    {
        if (File.Exists(FileName))
        {
            Console.Write("Are you sure you want to delete all goals? (y/n): ");
            string response = Console.ReadLine().ToLower();

            if (response == "y")
            {
                File.Delete(FileName);
                TotalScore = 0;
                HighestRankAchieved = -1; // Reset rank tracking 
                Goals.Clear();
                Console.WriteLine("Goals file deleted successfully.");
            }
            else
            {
                Console.WriteLine("Deletion canceled.");
            }
        }
        else
        {
            Console.WriteLine("No goals file to delete.");
        }
    }
}