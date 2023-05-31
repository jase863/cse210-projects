public class OutdoorGathering : Event
{
    string _weatherStatement;

    public OutdoorGathering(string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address)
    {

    }

    public OutdoorGathering(string eventType, string eventTitle, string description, string date, string time, Address address, string weatherStatement) : base(eventType, eventTitle, description, date, time, address)
    {  
        _weatherStatement = weatherStatement;
    } 

    public OutdoorGathering(string eventType, string eventTitle, string date) : base(eventType, eventTitle, date)
    {

    }

    public override void DisplayFullDetails()
    {
        Console.WriteLine($"\n{_eventType}\n{_eventTitle.ToUpper()}:\n{_description}.\n{_date} @ {_time}\n{_address.FormattedAddress()}\n{_weatherStatement}, so please plan accordingly.");
    }
}
