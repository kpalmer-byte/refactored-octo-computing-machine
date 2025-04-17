using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = ("");

        if (number >= 90)
        {
            letter = ("A");
        }

        else if (number >= 80)
        {
            letter = ("B");
        }

        else if (number >= 70)
        {
            letter = ("C");
        }


        else if (number >= 60)
        {
            letter = ("D");
        }

        else if (number < 60)
        {
            letter = ("F");
        }

        int last_digit = number % 10;
        string sign = "";

        if (last_digit >= 7)
            sign = "+";

        if (last_digit <= 3)
            sign = "-";

        if (number >= 93)
            sign = "";

        if (letter == "F")
            sign = "";
        
        Console.WriteLine($"Your grade is {letter}{sign}");

        if (number >= 70)
        {
            Console.WriteLine("You passed the class!");
        }

    }
}