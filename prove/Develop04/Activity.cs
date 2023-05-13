public class Activity
{
    // activity name
    protected string _activity;

    // activity description
    protected string _description;

    // user selected duration
    protected int _duration;

    // current time
    protected DateTime _currentTime = DateTime.Now;

    // holder for added time used later in the program
    protected DateTime _addedTime = new DateTime();

    // activity constructor
    public Activity()
    {
        _activity = "";
        _description = "";
        
    }

    protected void DisplayActivty(string activity, string description)
    {
        // welcome to the activity
        Console.WriteLine($"Welcome to the {_activity} Activity.\n");

        // description of the activity
        Console.WriteLine($"This activity will help you {_description}");

        Console.Write("\nHow Long, in seconds, would you like for your session? ");
        
        // allows user to set duration
        SetDuration();

        Console.Clear();
        
        Console.WriteLine("Get Ready...");
        WaitAnimation(3);
    }

    public int SetDuration()
    {
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    // produces a random integer; parameter is for a list length
    protected int GetRandomInt(int listCount)
    {
        Random randomInt = new Random();
        return randomInt.Next(0, listCount);
    }

    // spinner animation; parameter is for seconds that the spinner will go
    public void WaitAnimation(int seconds)
    {   
        DateTime currentTime = DateTime.Now;
        DateTime addedTime = currentTime.AddSeconds(seconds);

        while (DateTime.Now < addedTime)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");

            Console.Write("*");
            Thread.Sleep(200);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }

    // countdown to display; parameters are for amount of time to countdown, message to display to user
    public void Countdown(int time, string userMessage)
    {
        Console.Write($"{userMessage}...");

        for (int i=time; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        Console.WriteLine("\n");
    }

    // message to display to the user after the activity is complete
    protected void EndMessage(int duration)
    {
        Console.WriteLine("Nice Job!\n");
        WaitAnimation(2);

        Console.WriteLine($"You have completed {_duration} seconds of the {_activity} Activity!");

        WaitAnimation(2);
        Console.Clear();
    }
}   
