namespace console_store.Objects;

public class Product : IProduct
{
    public static readonly List<String> Kinds = [
        "Яблоко",
        "Банан",
        "Апельсин",
        "Киви"
    ];
    
    private string Name { get; }
    private decimal Price { get; }
    private int Quantity { get; }
    
    public Product(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public string GetName()
    {
        return Name;
    }

    public decimal GetPrice()
    {
        return Price;
    }

    public int GetQuantity()
    {
        return Quantity;
    }

    public List<string> GetKinds()
    {
        return Kinds;
    }
}