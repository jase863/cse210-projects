public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, int activityLength, string activityType, int numberOfLaps) : base(date, activityLength, activityType)
    {
        _date = date;
        _activityLength = activityLength;
        _activityType = activityType;
        _numberOfLaps = numberOfLaps;
    }
    public override double CalculateDistance()
    {
        return (_numberOfLaps * 50 / 1000) * 0.62;
    }

    public override double CalculateSpeed()
    {
        return (CalculateDistance() / _activityLength) * 60;
    }

    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }
}
