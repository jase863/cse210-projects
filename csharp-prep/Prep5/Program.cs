using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string name = PromptUserName();

        int userNumber = PromptUserNumber();

        int squared = SquareNumber(userNumber);

        Console.Write($"{name}, the square of your number is {squared}.");
    }
    
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
    
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }
    
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int squaredNumber = userNumber * userNumber;
        
        return squaredNumber;
    }
}
