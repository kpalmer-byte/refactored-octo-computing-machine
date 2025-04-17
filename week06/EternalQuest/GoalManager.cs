using System;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string[] menu = {"Create Goal", "List Goals", "Record Event", "Save Goals", "Load Goals", "Exit" };
        int action = 0;

        while (action != 8)
        {
            Console.Clear();
            Console.WriteLine("Goal Manager");
            Console.WriteLine("Please select one of the following:");

            // Display the menu options
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }

            Console.Write("Enter (1-6): ");
            int input = int.Parse(Console.ReadLine());
            action = input;

            if (action == 1)
            {
                CreateGoal();
            }

            else if (action == 2)
            {
                ListGoals();
            }
           
            else if (action == 3)
            {
                RecordEvent();
            }

            else if (action == 4)
            {
                SaveGoals();
            }
            else if (action == 5)
            {
                LoadGoals();
            }
            else if (action == 6)
            {
                Console.WriteLine("Exiting Goal Manager...");
            }
            else
            {
                Console.WriteLine("Invalid choice, please select between 1 and 6.");
            }

        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player's Score: {_score}");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
    public void ListGoals()
    {
        Console.WriteLine("Your Goals:");

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice (1-3): ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            SimpleGoal simple = new SimpleGoal(name, description, points);
            _goals.Add(simple);
        }
        else if (type == 2)
        {
            EternalGoal eternal = new EternalGoal(name, description, points);
            _goals.Add(eternal);
        }
        else if (type == 3)
        {
            Console.Write("Enter target number of completions: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus points for completion: ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklist);
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select the goal you accomplished:");

        // Display goals with numbering
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Enter the number of the goal: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice >= 1)
        {
            if (choice <= _goals.Count)
            {
                Goal selectedGoal = _goals[choice - 1];
                selectedGoal.RecordEvent();
                int earnedPoints = selectedGoal.GetPoints();
                _score += earnedPoints;

                Console.WriteLine($"Event recorded! You earned {earnedPoints} points.");
            }

            else
            {
                Console.WriteLine("Invalid selection.");
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter the filename to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score); // Save score at the top

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }



    public void LoadGoals()
    {
        Console.Write("Enter the filename to load from: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _goals.Clear();

            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]); // First line is the score

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");
                string goalType = parts[0];

                if (goalType == "SimpleGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isComplete = bool.Parse(parts[4]);

                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    if (isComplete)
                    {
                        goal.RecordEvent(); // Mark it complete
                    }
                    _goals.Add(goal);
                }
                else if (goalType == "EternalGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (goalType == "ChecklistGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);

                    // Recreate progress
                    for (int j = 0; j < amountCompleted; j++)
                    {
                        goal.RecordEvent();
                    }

                    _goals.Add(goal);
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}