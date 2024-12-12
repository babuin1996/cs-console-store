namespace console_store.Objects;

public interface IProduct
{
    public string GetName();
    public decimal GetPrice();
    public int GetQuantity();
    public List<String> GetKinds();
}