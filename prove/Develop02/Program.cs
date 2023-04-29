using System;
using System.Collections.Generic;

class Program
{
    
    static void Main(string[] args)
    {
        string option = "";

        // initialize a list for prompts
        Prompts promptsList = new Prompts();

        // initialize a variable for the journal class
        Journal journalInfo = new Journal();

        // while loop for the menu
        while (option.ToLower() != "quit" & option != "5")
        {
            Console.WriteLine("\nWelcome. Please choose a number option from the following list:");
            Console.WriteLine("\n1. New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");

            Console.Write("\nMenu Option: ");
            option = Console.ReadLine();

            // option 1 for adding a new entry
            if (option == "1")
            {
                Console.WriteLine("If you would like a new prompt, type 'new prompt'.");

                // variable to hold the elements of a new entry
                Entry newEntry = new Entry();

                // intialize entry variable for while loop
                newEntry.entry = "";

                // initialize variable for confirmation of entry to be added
                string confirmEntry = "no";

                // do...while loop to allow for a new prompt if desired
                do
                {
                    // variable for today's date
                    DateTime dateNow = DateTime.Now;

                    // converting the date to a string
                    newEntry.date = dateNow.ToShortDateString();

                    // generate a random prompt to display
                    newEntry.prompt = promptsList.Generator();

                    // insert a blank line for good whitespace
                    Console.WriteLine();

                    // display prompt
                    Console.WriteLine(newEntry.prompt);


                    // respond to prompt
                    newEntry.entry = Console.ReadLine();
                    
                    // loop to confirm whether entry should be added or rewritten
                    while (confirmEntry.ToLower() == "no" && newEntry.entry != "new prompt")
                    {
                        // show entry back to user and give the option to save it
                        Console.WriteLine($"\nYour entry: {newEntry.entry}");
                        Console.Write("\nWould you like to save it? ");
                    
                        // confirm save (yes or no)
                        confirmEntry = Console.ReadLine();
            
                        if (confirmEntry.ToLower() == "no")
                        {
                            Console.WriteLine("Please type a new entry or type 'new prompt':");
                            newEntry.entry = Console.ReadLine();
                        }   
                    }  
                } while (newEntry.entry == "new prompt");

                Console.WriteLine("\nEntry Saved");

                // add the entry to the journal list
                journalInfo.AddEntry(newEntry);
            }

            // option 2 for displaying the journal entries
            else if (option == "2")
            {
                Journal journal = new Journal();
                journalInfo.DisplayAll();

            }

            // option 3 for saving to a file
            else if (option == "3")
            {
                Console.Write("What would you like to call your file (do not add '.csv' or any other extension)? ");
                string file = Console.ReadLine() + ".csv";

                // foreach loop to go through all of the entries
                    
                    journalInfo.SaveToFile(file, journalInfo);
            }
            else if (option == "4")
            {   
                Console.Write("What is the name of the file (do not add '.csv' or any other extension)? ");
                string fileToOpen = Console.ReadLine() + ".csv";
                
               journalInfo.LoadFile(fileToOpen);
            }
                
        }

    } 
}
