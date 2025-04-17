using System.Collections.Generic;

class ListingActivity : Activity
{
    private int _count;
    List<string> _prompts;

    public ListingActivity()
        : base("Listing Activity",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"{prompt}");
    }

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("Start listing items. Press Enter after each one:");

        // Collect input until time runs out
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();  // Waits for user input (Enter key submits)

            if (input != "")  // Check if it's not an empty string
            {
                responses.Add(input);
            }
        }
        
        _count = responses.Count;

        return responses;
    }
    
    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);

        Console.WriteLine("You may begin in...");
        ShowCountDown(5); // Pause for user to think about the prompt

        List<string> responses = GetListFromUser();

        Console.WriteLine($"You listed {_count} things.");
        ShowSpinner(3);

        DisplayEndingMessage();
    }

}