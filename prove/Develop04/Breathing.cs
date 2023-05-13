public class Breathing : Activity
{
    // breathing constructor that initilizes the variables needed and runs the methods in the class
    public Breathing() : base()
    {
        _activity = "Breathing";
        _description = "relax by guiding you through breaths in and breaths out.\nTry to clear your thoughts and just focus on breathing.";
        
        DisplayActivty(_activity, _description);
        BreathePrompts(_duration);
        EndMessage(_duration);
    }


    // user decides how long to breathe in and out; parameter is the duration specified by the user
    public void BreathePrompts(int duration)
    {   
        Console.Write("Choose how many seconds you would like to breathe in: ");
        int inLength = int.Parse(Console.ReadLine());

        Console.Write("\nChoose how many seconds you would like to breathe out: ");
        int outLength = int.Parse(Console.ReadLine());

        Console.Clear();

        _addedTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < _addedTime)
        {   

            Console.WriteLine("");
            Countdown(inLength, "Breathe in");

            Countdown(outLength, "Breathe out");

        }
    }

}
