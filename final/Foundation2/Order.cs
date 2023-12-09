using System.Collections.Generic;
using System.Linq;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public double CalculateTotalCost()
    {
        double totalCost = products.Sum(product => product.CalculatePrice());
        return totalCost + (customer.IsInUSA() ? 5 : 35);
    }

    public string GetPackingLabel()
    {
        return $"Packing Label:\n{string.Join("\n", products.Select(product => $"{product.GetName()} - ID: {product.GetProductId()}"))}";
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {customer.Name}\nAddress: {customer.GetAddressString()}";
    }
}
