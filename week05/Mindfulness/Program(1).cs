using System;

class Program
{
    static void Main(string[] args)
    {
        string[] menu = { "Breathing Activity", "Listing Activity", "Reflecting Activity", "Quit" };

        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();

        int action = 0;

        while (action != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }

            Console.Write("Select an option (1-4): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out action))
            {
                if (action == 1)
                {
                    breathing.Run();
                }
                else if (action == 2)
                {
                    listing.Run();
                }
                else if (action == 3)
                {
                    reflection.Run();
                }
                else if (action == 4)
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
}