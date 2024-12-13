namespace console_store.Objects;

public class Customer : ICustomer
{
    private decimal _balance;

    public Customer()
    {
        var random = new Random();
        _balance = random.Next(100);
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    private void SetBalance(decimal amount)
    {
        _balance = amount;
    }

    public void WithdrawBalance(decimal amount)
    {
        if (amount < 0)
        {
            throw new Exception("Списание не может быть отрицательным");
        }
        
        if (amount > _balance) {
            string message = $"На балансе недостаточно средств: {GetBalance()} USD, необходимо: {amount} USD.";
            throw new Exception(message);
        }
        
        SetBalance(_balance - amount);
    }
}