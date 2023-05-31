public class Event
{
    protected string _eventType;
    protected string _eventTitle;	
    protected string _description;		
    protected string _date;		
    protected string _time;		
    protected Address _address;

    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public Event(string eventType, string eventTitle, string description, string date, string time, Address address)
    {   
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public Event(string eventType, string eventTitle, string date)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _date = date;
    }
    public void DisplayStandardDetails()
    {
        Console.WriteLine($"\n{_eventTitle.ToUpper()}:\n{_description}.\n{_date} @ {_time}\n{_address.FormattedAddress()}");
    }		
    public virtual void DisplayFullDetails()
    {
        Console.WriteLine($"\n{_eventType}\n{_eventTitle.ToUpper()}:\n{_description}.\n{_date} @ {_time}\n{_address.FormattedAddress()}");
    }		
    public void DisplayShortDescription()
    {
        Console.WriteLine($"\n{_eventType}\n{_eventTitle.ToUpper()}\n{_date}");
    }		

}
