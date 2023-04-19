using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        int total = 0;
        int max = -1;

        Console.Write("Enter as many numbers as you'd like. Once you're done entering numbers, enter 0.\n");

        while (userNumber != 0)
        {
            Console.Write("\nEnter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } 

        foreach (int number in numbers)
        {
            total += number;

            if (number > max)
            {
                max = number;
            }
        }

        float average = ((float)total / numbers.Count);

        Console.WriteLine($"\nThe sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
