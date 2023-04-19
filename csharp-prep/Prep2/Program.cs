using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeLetter = "";

        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        if (percentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (percentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (percentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (percentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"\nYour grade is: {gradeLetter}\n");

        if (percentage >= 70)
        {
            Console.Write($"Congratulations! You have passed!");
        }
        else
        {
            Console.Write("Unfortunately, you did not pass. Keep trying, and you'll get it!");
        }
    }
}
