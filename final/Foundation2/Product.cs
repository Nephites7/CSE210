class Product
{
    private string name;
    private decimal price;

    public Product(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }

    public string GetName()
    {
        return name;
    }

    public decimal GetPrice()
    {
        return price;
    }
}
