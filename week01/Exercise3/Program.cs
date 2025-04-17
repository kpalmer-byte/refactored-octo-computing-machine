using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;
        int tries = -1;

        do
        {
            tries += 1;
            Console.Write("Pick a number between 1-100: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("higher");
            }

            else if (guess > number)
            {
                Console.WriteLine("lower");
            }
        } while (guess != number);

        if (guess == number)
            Console.WriteLine($"That is correct! The answer was {number}.");
        Console.WriteLine($"It took you {tries} tries");
    }       
    
}