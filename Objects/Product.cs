namespace console_store.Objects;

public class Product : IProduct
{
    public static readonly List<String> Kinds = [
        "Яблоко",
        "Банан",
        "Апельсин",
        "Киви"
    ];
    
    private int Id { get; }
    private string Name { get; }
    private decimal Price { get; }
    
    public Product(string name, decimal price, int id)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public int GetId()
    {
        return Id;
    }

    public string GetName()
    {
        return Name;
    }

    public decimal GetPrice()
    {
        return Price;
    }

    public List<string> GetKinds()
    {
        return Kinds;
    }
}