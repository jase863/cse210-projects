public class Goal 
{

    AllGoals allGoals = new AllGoals();
    protected string _goal;
    protected int _totalScore = 0;
    protected string _description;
    protected string _goalType;
    protected int _earnedPoints = 0;
    protected bool _completed;

    public Goal()
    {
        _goalType = GetGoalType(); 
    }
    public Goal(string goalType, string goal, string description, int earnedPoints)
    {
        _goal = goal;
        _description = description;
        _earnedPoints = earnedPoints;
        _goalType = GetGoalType();
    }
    public virtual Goal CreateNewGoal(string goalType)
    {
        Goal newGoal = new Goal();
        
        Console.Write("What is the name of your goal? ");
        newGoal._goal = Console.ReadLine();

        Console.Write("Give a short description of the goal: ");
        newGoal._description = Console.ReadLine(); 

        Console.Write("How many points is this goal worth? ");
        newGoal._earnedPoints = int.Parse(Console.ReadLine());

        newGoal._goalType = goalType;

        return newGoal;
    }

    public virtual void DisplayFormat()
    {   
        if (GetComplete())
            {
                Console.WriteLine($"[x] {GetGoal()} ({GetDescription()})");
            }

            else
            {
                Console.WriteLine($"[ ] {GetGoal()} ({GetDescription()})");

            }
    }

    public virtual string SaveFormat()
    {
        string format = $"{GetGoalType()}|{GetGoal()}|{GetDescription()}|{GetEarnedPoints()}|{GetComplete()}";

        return format;
    }

    public virtual void LoadFormat()
    {
        
    }

    public string GetGoal()
    {
        return _goal;
    }

    public void SetGoal()
    {
        _goal = Console.ReadLine();
    }

    public virtual int RecordEvent()
    {
        Console.WriteLine("\nNice job!");
        Console.WriteLine($"You earned {_earnedPoints} points!");
        
        return _earnedPoints;
    }
    public int GetEarnedPoints()
    {
        return _earnedPoints;
    }

    public string GetDescription()
    {
        return _description;
    }
    public virtual int SetTotalScore(int score)
    {
        _totalScore += score;

        return _totalScore;
    }

    public int SetEarnedPoints(int points)
    {
        _earnedPoints += points;

        return _earnedPoints;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    public string SetGoalType(string goalType)
    {
        _goalType = goalType;

        return goalType;
    }
    
    public virtual void SetComplete()
    {
        _completed = true;
    }

    public bool GetComplete()
    {
        return _completed;
    }
}
