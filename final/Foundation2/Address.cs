public class Address
{
    private string _streetAddress;	
    private string _city;		
    private string _stateOrProvince;		
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }	
    public bool GetInUSA(string country)
    {
        if (country == "USA")
        {
            return true;
        }

        else
        {
            return false;
        }
    }		
    
    public string FormattedAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }	

    public string GetCity()
    {
        return _city;
    }		

    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }	

    public string GetCountry()
    {
        return _country;
    }
}
