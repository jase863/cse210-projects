public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int activityLength, string activityType, double speed) : base(date, activityLength, activityType)
    {
        _date = date;
        _activityLength = activityLength;
        _activityType = activityType;
        _speed = speed;
    }
    public override double CalculateDistance()
    {
        return (_speed * _activityLength) / 60;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityType} ({_activityLength} min) - Distance: {CalculateDistance():N2} miles, Speed: {_speed} mph, Pace: {CalculatePace():N2} min per mile");
    }
}
