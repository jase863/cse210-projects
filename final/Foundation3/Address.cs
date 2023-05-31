public class Address
{
    private string _streetAddress;	
    private string _city;		
    private string _state;		

    public Address(string streetAddress, string city, string state)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
    }
    public string FormattedAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}";
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }	

    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }		

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }


}

