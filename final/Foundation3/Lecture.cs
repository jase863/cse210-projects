public class Lecture : Event
{
    private string _speaker;
    private string _capacity;

    public Lecture(string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address)
    {

    }

    public Lecture(string eventType, string eventTitle, string description, string date, string time, Address address, string speaker, string capacity) : base(eventType, eventTitle, description, date, time, address)
    {   
        _speaker = speaker;
        _capacity = capacity;
    }

    public Lecture(string eventType, string eventTitle, string date) : base(eventType, eventTitle, date)
    {

    }

    public override void DisplayFullDetails()
    {
       Console.WriteLine($"\n{_eventType}\n{_eventTitle.ToUpper()}:\n{_description}.\nFeaturing Special Guest Speaker, {_speaker}.\nSeating is limited to {_capacity} persons.\n{_date} @ {_time}\n{_address.FormattedAddress()}");
    }
}
