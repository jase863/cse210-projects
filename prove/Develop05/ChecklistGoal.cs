public class ChecklistGoal : Goal
{
    private int _timesCompleted = 0;
    private int _timesNeeded;
    private int _bonusPoints = 0;
    private bool _goalComplete;

    public ChecklistGoal()
    {
    }

    public ChecklistGoal(string goalType, string goal,  string description, int earnedPoints, int timesCompleted, int timesNeeded, int bonusPoints, bool completedStatus): base(goalType, goal, description, earnedPoints)
    {   
        _goalType = "ChecklistGoal";
        _goal = goal;
        _description = description;
        _earnedPoints = earnedPoints;
        _timesCompleted = timesCompleted;
        _timesNeeded = timesNeeded;
        _bonusPoints = bonusPoints;
        _goalComplete = completedStatus;
        
    }

    public override Goal CreateNewGoal(string goalType)
    {   
        ChecklistGoal newGoal = new ChecklistGoal();

        Console.Write("What is the name of your goal? ");
        newGoal._goal = Console.ReadLine();

        Console.Write("Give a short description of the goal: ");
        newGoal._description = Console.ReadLine(); 

        Console.Write("How many points is this goal worth? ");
        newGoal._earnedPoints = int.Parse(Console.ReadLine());

        Console.Write("How many times do you need to accomplish your goal to get bonus points? ");
        newGoal._timesNeeded = int.Parse(Console.ReadLine());

        Console.Write($"What is the bonus for accomplishing the goal that many times? ");
        newGoal._bonusPoints = int.Parse(Console.ReadLine());

        newGoal._goalType = "ChecklistGoal";

        return newGoal;
    }

    public override void DisplayFormat()
    {
        if (GetComplete())
        {
            Console.WriteLine($"[x] {GetGoal()} ({GetDescription()}) -- Completed");
        }

        else
        {
            Console.WriteLine($"[ ] {GetGoal()} ({GetDescription()}) -- {GetTimesCompleted()}/{GetTimesNeeded()}");
        }
        
    }

    public override string SaveFormat()
    {
        string format = $"{GetGoalType()}|{GetGoal()}|{GetDescription()}|{GetEarnedPoints()}|{GetTimesCompleted()}|{GetTimesNeeded()}|{GetBonusPoints()}|{GetComplete()}";

        return format;
    }   

    public override void SetComplete()
    {

        if (_timesCompleted == _timesNeeded)
        {
            _completed = true;
            
        }

        else
        {
            _completed = false;
        }

    }

    public override int RecordEvent()
    {
        Console.WriteLine("Nice work!");
        Console.WriteLine($"You earned {_earnedPoints} points!");

        _timesCompleted += 1;

        SetComplete();

        if (_completed)
        {   
            Console.Clear();
            for (int i=0; i < 2; i++)
            {
                Thread.Sleep(300);
                Console.Write("Y");
                Thread.Sleep(200);
                Console.Write("O");
                Thread.Sleep(200);
                Console.Write("U");
                Thread.Sleep(200);
                Console.Write(" ");
                Thread.Sleep(400);
                Console.Write("R");
                Thread.Sleep(200);
                Console.Write("O");
                Thread.Sleep(200);
                Console.Write("C");
                Thread.Sleep(200);
                Console.Write("K");
                Thread.Sleep(200);
                Console.Write("!");
                Thread.Sleep(200);
                Console.Write("!");
                Thread.Sleep(200);
                Console.Write("!");
                Thread.Sleep(500);
                Console.Clear();
                Thread.Sleep(300);
                Console.Write("YOU ROCK!!!");
                Thread.Sleep(300);
                Console.Clear();
                Thread.Sleep(300);
                Console.Write("YOU ROCK!!!");
                Thread.Sleep(300);
                Console.Clear();
                Thread.Sleep(300);
                Console.Write("YOU ROCK!!!");
                Console.Clear();
            }
            Console.WriteLine($"Awesome! You got {_bonusPoints} bonus points for completing your goal!");
            _earnedPoints += _bonusPoints;
        }

        return _earnedPoints;

        
    }

    // public void SetGoalType(string goalType)
    // {
    //     _goalType = goalType;
    // }

    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    public int GetTimesNeeded()
    {
        return _timesNeeded;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
}
