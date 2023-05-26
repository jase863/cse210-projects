public class Customer
{
    private string _customerName; 
    private Address _address; 

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool IsInUSA()
    {   
        return _address.GetInUSA(_address.GetCountry());
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
    
    public string GetAddressString()
    {
        return _address.FormattedAddress();
    }

}
