using System;
using System.ComponentModel;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int total = 0;
        float average = 0;
        int number = -1;
        int largest = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string entry = Console.ReadLine();
            number = int.Parse(entry);
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        foreach (int num in numbers)
        {
            total += num;
            if (num > largest)
            {
                largest = num;
            }
        }

        if (numbers.Count > 0)
        {
            average = (float)total / numbers.Count;
        }

        Console.WriteLine($"The total is: {total} The average is: {average} The largest number is {largest}");
    }
}