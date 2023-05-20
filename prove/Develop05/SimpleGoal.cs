public class SimpleGoal : Goal
{
    private bool _goalComplete;
    private new string _goalType = "SimpleGoal";
    public SimpleGoal()
    {
    }

    public SimpleGoal(string goalType, string goal, string description, int earnedPoints, bool completedStatus): base(goalType, goal, description, earnedPoints)
    {   
        _goalType = SetGoalType(goalType);
        _goal = goal;
        _description = description;
        _earnedPoints = earnedPoints;
        _goalComplete = completedStatus;
    }


    public override int RecordEvent()
    {
        Console.WriteLine($"Nice job! You have earned {_earnedPoints}");
        SetComplete();
        return _earnedPoints;
    }
    // public void SetGoal()
    // {
    //     _goal = CreateNewGoal();
    // }
}
