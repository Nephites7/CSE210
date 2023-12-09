public class Product
{
    private string name;
    private int productId; // Add productId
    private double price; // Change decimal to double
    private int quantity; // Add quantity

    public Product(string name, int productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string GetName()
    {
        return name;
    }

    public int GetProductId()
    {
        return productId;
    }

    public double CalculatePrice()
    {
        return price * quantity;
    }
}
