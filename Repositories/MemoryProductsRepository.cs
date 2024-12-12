using console_store.Objects;

namespace console_store.Repositories;

class MemoryProductsRepository : IProductsRepository
{
    private readonly Random _random = new();
    private readonly List<IProduct> _products = [];

    public MemoryProductsRepository()
    {
        foreach (String productName in Product.Kinds)
        {
            _products.Add(new Product(
                productName,
                GetProductPrice(),
                GetProductQuantity()
                ));
        }
    }

    public List<IProduct> GetProducts()
    {
        return _products;
    }

    private decimal GetProductPrice()
    {
        return new decimal(double.Round(_random.NextDouble() * 5, 2));
    }

    private int GetProductQuantity()
    {
        return _random.Next(1, 10);
    }
}