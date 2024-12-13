namespace console_store.Objects;

public class Cart : ICart
{
    private Dictionary<string, int> _purchases;

    public Cart()
    {
        _purchases = new Dictionary<string, int>();
    }
    
    public Dictionary<string, int> GetPurchases()
    {
        return _purchases;
    }

    public void BuyProduct(IProduct product, ICustomer customer)
    {
        customer.WithdrawBalance(product.GetPrice());
        
        if (_purchases.ContainsKey(product.GetName())) {
            _purchases[product.GetName()]++;
        } else {
            _purchases.Add(product.GetName(), 1);
        }
    }
}