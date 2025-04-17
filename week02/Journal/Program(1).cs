using System;
using System.Formats.Tar;

class Program
{
    static void Main(string[] args)
    {
        string[] menu = { "Write", "Display", "Load", "Save", "Quit" };
        int action = 0;

        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        while (action != 5)
        {
            Console.WriteLine("Please select one of the following:");

            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }

            Console.Write("Enter (1-5): ");
            int input = int.Parse(Console.ReadLine());
            action = input;

            if (action == 1) // Write
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");

                Console.Write("Your entry: ");
                string entryText = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                // Added Creativity: Prompt the user to input an entry type
                Console.Write("Enter entry type (e.g., Emotional, Work, Family, Spiritual): ");
                string entryType = Console.ReadLine();


                Entry entry = new Entry();
                entry._date = dateText;
                entry._promptText = prompt;
                entry._entryText = entryText;
                entry._entryType = entryType;

                myJournal.AddEntry(entry);
                Console.WriteLine("Entry added!");
            }

            else if (action == 2) // Display
            {
                Console.WriteLine("Displaying all journal entries:");
                myJournal.DisplayAll();
            }

            else if (action == 3) // Load
            {
                Console.Write("Enter the file path to load from: ");
                string loadPath = Console.ReadLine();
                if (System.IO.File.Exists(loadPath))
                {
                    myJournal.LoadFromFile(loadPath);
                    Console.WriteLine("Entries loaded!");
                }
            }

            else if (action == 4) // Save
            {
                Console.Write("Enter the file path to save to: ");
                string savePath = Console.ReadLine();
                myJournal.SaveToFile(savePath);
                Console.WriteLine("Entries saved!");
            }
            
        }
    }
}