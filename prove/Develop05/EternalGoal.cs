public class EternalGoal : Goal
{
    private string _goalType = "EternalGoal";

    public EternalGoal()
    {
        _goalType = "EternalGoal";
    }
    public EternalGoal(string goalType, string goal, string description, int earnedPoints): base(goalType, goal, description, earnedPoints)
    {
        _goalType = SetGoalType(goalType);
        _goal = goal;
        _description = description;
        _earnedPoints = earnedPoints;

    }

    public override void DisplayFormat()
    {
        Console.WriteLine($"[ ] {GetGoal()} ({GetDescription()})");
    }
    public override string SaveFormat()
    {
        string format = $"{GetGoalType()}|{GetGoal()}|{GetDescription()}|{GetEarnedPoints()}";

        return format;
    }
}
