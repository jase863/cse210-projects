public class Reception : Event
{
    private string _rsvp;

    public Reception(string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address)
    {

    }

    public Reception(string eventType, string eventTitle, string description, string date, string time, Address address, string rsvp) : base(eventType, eventTitle, description, date, time, address)
    {  
        _rsvp = rsvp;
    } 

    public Reception(string eventType, string eventTitle, string date) : base(eventType, eventTitle, date)
    {

    }

    public override void DisplayFullDetails()
    {
        Console.WriteLine($"\n{_eventType}\n{_eventTitle.ToUpper()}:\n{_description}.\n{_date} @ {_time}\n{_address.FormattedAddress()}\nPlease RSVP to {_rsvp}");
    }
}
