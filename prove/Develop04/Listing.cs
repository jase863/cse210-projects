public class Listing : Activity
{   
    // prompt questions for the listing
    private List<string> _listingPrompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?",
    "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    // listing constructor that initilizes the variables needed and runs the methods in the class
    public Listing() : base()
    {
        _activity = "Listing";
        _description = "remember good things that have happened in your life by listing them, according to the supplied prompt.";
        
        DisplayActivty(_activity, _description);
        DisplayListing();
        ListInput(_duration);
        EndMessage(_duration);
    }

    // gets a random prompt for the user
    private string GetRandomPrompt()
    {
        return _listingPrompts[GetRandomInt(_listingPrompts.Count)];
    }

    // instructions for the user
    private void DisplayListing()
    {
        Console.WriteLine("\nList as many responses as you can to the following prompt:\n");

        Console.WriteLine($"---{GetRandomPrompt()}---\n");
        Countdown(5, "You may begin in");
    }

    // gets listed information and saves it to a temporary list
    private void ListInput(int duration)
    {   
        List<string> listed = new List<string>{};

        Console.WriteLine();

        _addedTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < _addedTime)
        {  
            Console.Write($"> ");
            string listItem = Console.ReadLine();

            listed.Add(listItem);

            Console.WriteLine("\n");  
        }

        Console.WriteLine($"You listed {listed.Count} items!\n");
    }
}
