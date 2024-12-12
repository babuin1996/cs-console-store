namespace console_store.Objects;

public class Customer : ICustomer
{
    private decimal _balance;

    public Customer()
    {
        var random = new Random();
        _balance = random.Next(200);
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}