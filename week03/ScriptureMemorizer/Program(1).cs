using System;

// For the stretch challenge: Have your program work with a library of scriptures rather than a single one. 
// Choose scriptures at random to present to the user.
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not on thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Daniel", 1, 17), "As for these four children, God gave them knowledge and skill in all learning and wisdom: and Daniel had understanding in all visions and dreams."),
            new Scripture(new Reference("3 Nephi", 14, 7), "Ask, and it shall be given unto you; seek, and ye shall find; knock, and it shall be opened unto you.")
        };

        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress 'Enter' to hide a random word, or type 'quit' to exit.");

            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            if (userInput == "")
            {
                scripture.HideRandomWords(3);

                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
            }
        }

        Console.WriteLine("\nDo you have the scripture memorized now? Good job!");
    }
}