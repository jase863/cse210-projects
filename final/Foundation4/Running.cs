public class Running : Activity
{
    private double _distance;

    public Running(string date, int activityLength, string activityType, double distance) : base(date, activityLength, activityType)
    {
        _date = date;
        _activityLength = activityLength;
        _activityType = activityType;
        _distance = distance;
    }

    public override double CalculateSpeed()
    {
        return (_distance / _activityLength) * 60;
    }

    public override double CalculatePace()
    {
        return _activityLength / _distance;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityType} ({_activityLength} min) - Distance: {_distance} miles, Speed: {CalculateSpeed():N2} mph, Pace: {CalculatePace():N2} min per mile");
    }
}
