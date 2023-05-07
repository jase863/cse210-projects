using System;

// FOR THE ADDING CREATIVITY PORTION, I ADDED THE OPTION TO GET A RANDOM SCRIPTURE REFERENCE, WHICH CORRESPONDS TO THE VERSE.
// I ALSO ADDED THE OPTION FOR THE USER TO CHOOSE HOW MANY VERSES TO REMOVE.

class Program
{
    static void Main(string[] args)
    {    
        // creates instances of classes  
        Reference reference = new Reference();
        Scripture scripture = new Scripture(reference);

        // initializs variable for continuing program
        string proceed = "";
       
        // while loop checking for "quit" as the console input, or no remaining words
        while (proceed.ToLower() != "quit" && scripture.RemainingWords() == true)
        {   
            // clears console to allow for hiding words
            Console.Clear();

            // gets scripture text, including hidden words
            Console.WriteLine(scripture.GetText());
            Console.Write("\nPress 'enter' to remove words from the verse. Type 'quit' when you're finished. > ");

            // input to console, allowing for an option to quit
            proceed = Console.ReadLine();

            // call to the method to hide words
            scripture.HideWords();
        }
        // clears hidden words in console and delivers encouraging message
        Console.Clear();
        Console.WriteLine("\nGood work! You can always come back if you need help memorizing again.");
    }
}
