using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Top 10 Fails of 2025", "CaptJacob", 600);
        Video video2 = new Video("How to Make Toast", "ChefCorinne", 1500);
        Video video3 = new Video("How to Master Blades in 60 seconds: part 1", "blademaster", 30);

        video1.AddComment(new Comments("blademaster", "Wow! @1:30 I hope she didn't get too hurt"));
        video1.AddComment(new Comments("misty", "double fail at no.3"));
        video1.AddComment(new Comments("Daniel", "Oh no! Did they take her to the hospital?"));
        video1.AddComment(new Comments("desertrider", "That is hilarious!"));

        video2.AddComment(new Comments("blademaster", "HOW DID I STILL BURN THIS?!"));
        video2.AddComment(new Comments("bloon-boi", "please note... don’t use a fork"));
        video2.AddComment(new Comments("Amelia", "This is my new favorite Avocado Toast."));
        video2.AddComment(new Comments("lenz", "wait... so you don’t microwave it?"));
        video2.AddComment(new Comments("toastmaster", "Cheers!"));
        video2.AddComment(new Comments("fakename", "best thing since sliced bread"));
        video2.AddComment(new Comments("Derek", "How did you get the fried egg to sit inside the toast and not burn? "));

        video3.AddComment(new Comments("ChefCorinne", "Are you the one that sliced my bread?"));
        video3.AddComment(new Comments("Jenny", "I love how you carved a bird in that roast beef."));
        video3.AddComment(new Comments("sillyGoose", "Let’s bring back dueling."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}