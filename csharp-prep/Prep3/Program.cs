using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

        Console.WriteLine(magicNumber);

        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {

            Console.Write("\nWhat is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("\nLower\n");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("\nHigher\n");
            }
            else
            {
                Console.Write($"\nThe Magic Number is {guessNumber}!");
            }
        }
        
    }
}
