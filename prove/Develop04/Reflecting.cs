public class Reflecting : Activity
{   
    // lists for both the starting prompts and the follow-up questions
    private List<string> _startPrompts = new List<string> {"Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.", "Think of a time when you reminded someone that they matter."};
    private List<string> _reflectPrompts = new List<string> {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"};

    // reflecting constructor that initilizes the variables needed and runs the methods in the class
    public Reflecting() : base()
    {
        _activity = "Reflecting";
        _description = "reflect on times when you've been able to overcome challenges. It will help you to remember the strength\nand determination that you've shown in your life.";
        
        DisplayActivty(_activity, _description);
        DisplayStartPrompt();
        DisplayReflectPrompt(_duration);
        EndMessage(_duration);

    }
  
    public void DisplayStartPrompt()
    {   

        Console.WriteLine("\nConsider the following prompt: \n");
        Console.WriteLine($"---{_startPrompts[GetRandomInt(_startPrompts.Count)]}---\n");
        Console.Write("When you have thought of something, press 'enter'.");
        Console.ReadLine();
        Console.Clear();
    }

    public void DisplayReflectPrompt(int duration)
    {
        Console.WriteLine("\nNow, ponder each of the following questions as they relate to your experience.\n");
        Countdown(5, "You may begin in");
        Console.Clear();

        _addedTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < _addedTime)
        {  
            Console.Write($"> {_reflectPrompts[GetRandomInt(_reflectPrompts.Count)]} ");
        
            WaitAnimation(5);
            Console.WriteLine("\n");  
        }
    }
}   
