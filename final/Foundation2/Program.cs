using System;
using System.Collections.Generic;

class AppEntryPoint
{
    static void Main()
    {
        var address1 = new Address("123 Main St", "CityA", "StateA", "USA");
        var customer1 = new Customer("CustomerA", address1);
        var products1 = new List<Product>
        {
            new Product("ProductX", 1, 10.99, 2),
            new Product("ProductY", 2, 5.99, 3),
        };
        var order1 = new Order(customer1, products1);

        var address2 = new Address("456 Oak St", "CityB", "StateB", "Canada");
        var customer2 = new Customer("CustomerB", address2);
        var products2 = new List<Product>
        {
            new Product("ProductZ", 3, 15.99, 1),
            new Product("ProductW", 4, 8.99, 2),
        };
        var order2 = new Order(customer2, products2);

        // Display order information
        DisplayOrderInfo(order1);
        DisplayOrderInfo(order2);
    }

    static void DisplayOrderInfo(Order order)
    {
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
    }
}
