using System;

class Program
{

    // IN ORDER TO EXCEED REQUIREMENTS, I ADDED AN OPTION FOR THE USER TO SPECIFY HOW LONG THEY WANT TO BREATHE IN AND OUT. IT IS FOUND
    // IN THE BREATHING CLASS. I ALSO ADDED A RANDOM PROMPT GENERATOR TO GET INTEGERS FOR THE INDICES OF MY LISTS.


    static void Main(string[] args)
    {
        // initialize option variable
        string option = "";

        // loop for menu options
        while (option.ToLower() != "quit" && option.ToLower() != "4")
        {
            Console.WriteLine("Welcome to Mindfullness\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Choose an option from the menu: ");

            option = Console.ReadLine();

            // breathing activity
            if (option == "1")
            {
                Console.Clear();
                new Breathing();
            }

            // reflecting activity
            else if (option == "2")
            {
                Console.Clear();
                new Reflecting();
            }

            // listing Activity
            else if (option == "3")
            {   
                Console.Clear();
                new Listing();
            }

            Console.Clear();

        }

        Console.WriteLine("Thank you for using Mindfulness");
    }

}
