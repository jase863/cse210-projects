using System;

class Program
{
    static void Main(string[] args)
    {   
        // First Order
        Address address1 = new Address("27 Duke of Gloucester Street", "Williamsburg", "Virginia", "USA");

        Customer customer1 = new Customer("Jason Rackham", address1);

        Order order1 = new Order(customer1);

        Product customer1Product1 = new Product("Hairy Belly Fannypack", "b355-9224", 6.99, 2);
        order1.GetProductsList().Add(customer1Product1);
        
        Product customer1Product2 = new Product("Miracle Hair Growth Serum", "i926842-47", 25.42, 1);
        order1.GetProductsList().Add(customer1Product2);
        
        Product customer1Product3 = new Product("Shotgun Cleaning Kit", "d478-94867", 12.45, 1);
        order1.GetProductsList().Add(customer1Product3);

        order1.DisplayOrderInfo();

        // Second Order

        Address address2 = new Address("Traumgasse 15", "Wetzikon", "Kanton Zürich", "Switzerland");

        Customer customer2 = new Customer("Hermann Metzger", address2);

        Order order2 = new Order(customer2);

        Product customer2Product1 = new Product("Adjustable Hiking Stick", "h45394-8463", 21.87, 2);
        order2.GetProductsList().Add(customer2Product1);
        
        Product customer2Product2 = new Product("Real Leather Boots", "s283732-57", 75.47, 2);
        order2.GetProductsList().Add(customer2Product2);
        
        Product customer2Product3 = new Product("Warm Fleece Jacket", "n68-37339464", 85.43, 1);
        order2.GetProductsList().Add(customer2Product3);

        Product customer2Product4 = new Product("Raclette Grill", "w93773-64376", 56.23, 1);
        order2.GetProductsList().Add(customer2Product4);

        order2.DisplayOrderInfo();

    }
}
