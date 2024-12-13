namespace console_store.Objects;

public interface IProduct
{
    public int GetId();
    public string GetName();
    public decimal GetPrice();
    public List<String> GetKinds();
}