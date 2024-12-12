namespace console_store.Objects;

public interface ICart
{
    public Dictionary<string, int> GetPurchases();
    public void AddProduct(IProduct product);
}