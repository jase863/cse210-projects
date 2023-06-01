public class Activity
{
    protected string _date;
    protected int _activityLength;
    protected string _activityType;

    public Activity(string date, int activityLength, string activityType)
    {
        _date = date;
        _activityLength = activityLength;
        _activityType = activityType;
    }
    public virtual double CalculateDistance()
    {
        return 1 * 50 / 1000 * 0.62;
    }

    public virtual double CalculateSpeed()
    {
        return (1 / _activityLength) * 60;
    }

    public virtual double CalculatePace()
    {
        return _activityLength / 10;
    }
    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityType} ({_activityLength} min) - Distance: {CalculateDistance():N2} miles, Speed: {CalculateSpeed():N2} mph, Pace: {CalculatePace():N2} min per mile");
    }
}
