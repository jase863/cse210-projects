public class Order
{
    private List <Product> _productsList = new List <Product>();		
    private Customer _customer; 
    private double _totalOrderPrice = 0;	

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public string CalculateTotalPrice()
    {
        foreach (Product product in _productsList)
        {
            _totalOrderPrice += product.CalculatePrice();
        }

        if (_customer.IsInUSA())
        {
            return ($"{_totalOrderPrice + 5:N2}");
        }

        else
        {
            return ($"{_totalOrderPrice + 35:N2}");
        }
    }	
    
    public void CreatePackingLabel()
    {
        foreach(Product product in _productsList)
        {   
            if (product.GetQuantity() == 1)
            {
                Console.WriteLine($"1  X  {product.GetProductName()} - {product.GetProductID()}  @  ${product.GetPrice()}");
            }

            else
            {
                Console.WriteLine($"{product.GetQuantity()}  X  {product.GetProductName()} - {product.GetProductID()}  @  ${product.GetPrice()}");
            }
        } 
    }		
    
    public void CreateShippingLabel(Customer _customer)
    {
        Console.WriteLine($"{_customer.GetCustomerName()}\n{_customer.GetAddressString()}\n");
        Console.WriteLine("-------------------\n");
    }		
    
    public List<Product> GetProductsList()
    {
        return _productsList;
    }		
    
    public Customer	GetCustomer()
    {
        return _customer;
    }	

    public void DisplayOrderInfo()
    {
        Console.WriteLine("-------------------\n");
        Console.WriteLine("Packing Label:\n");
        CreatePackingLabel();
        
        Console.WriteLine($"\nTotal Price: ${CalculateTotalPrice()}");

        Console.WriteLine("\n\nShipping Label:\n");
        CreateShippingLabel(GetCustomer());
    }
}
