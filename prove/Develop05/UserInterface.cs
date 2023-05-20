public class  UserInterface
{   
    
    public string MainInterface()
    {
        List<string> menuOptionsList = new List<string>{"1. Create New Goal", "2. Goals List", "3. Save Goals", "4. Load Goals", "5. Record Event", "6. Quit"};
        Console.WriteLine("\nMenu Options:");

        foreach(string option in menuOptionsList)
        {
            Console.WriteLine($"   {option}");
        }
        
        Console.Write("\nSelect an option: ");
        string choice = Console.ReadLine();
        Console.Clear();

        return choice;
    }

    public string OptionOne()
    {
        List<string> menuOptionsList = new List<string>{"1. Simple Goal", "2. Eternal Goal", "3. Checklist Goal"};

        string choice = "";

        string subOption1 = "";

        while (choice != "1" && choice != "2" && choice != "3")
        {
            Console.WriteLine("Goals Types: ");

            foreach(string option in menuOptionsList)
            {
                Console.WriteLine($"   {option}");
            }
            Console.Write("\n Which type of goal would you like to create? ");

            choice = Console.ReadLine();
            Console.Clear();

            // simple goal
            if (choice == "1")
            {   
                subOption1 = "1";
            }

            // eternal goal
            else if (choice == "2")
            {
                subOption1 = "2";
            }

            // checklist goal
            else if (choice == "3")
            {
                subOption1 = "3";
            }
            
        }

        return subOption1;
    }
}
