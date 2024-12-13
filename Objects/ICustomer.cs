namespace console_store.Objects;

public interface ICustomer
{
    public decimal GetBalance();
    public void WithdrawBalance(decimal amount);
}