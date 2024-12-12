using console_store.Objects;
using console_store.Repositories;

namespace console_store;

class Program
{
    static void Main(string[] args)
    {
        var repository = GetRepository();
        var products = repository.GetProducts();
        var customer = new Customer();
        var cart = new Cart();

        try {
            ShowAvailableProducts(products);
        } catch (Exception e) {
            Console.WriteLine(e);
            throw;
        } finally {
            ShowCustomerBalance(customer);
            ShowCartInfo(cart);
        }
    }

    private static IProductsRepository GetRepository()
    {
        return new MemoryProductsRepository();
    }

    private static void ShowAvailableProducts(List<IProduct> products)
    {
        string message = "Товары в наличии:\n";
        
        foreach (IProduct product in products)
        {
            message += $"\nНазвание товара: {product.GetName()}\n" +
                             $"В наличии шт.: {product.GetQuantity()}\n" +
                             $"Цена товара: {product.GetPrice()} usd\n";
            
        }
        
        Console.WriteLine(message);
    }

    private static void ShowCustomerBalance(ICustomer customer)
    {
        string message = $"Ваш баланс: {customer.GetBalance()}";
            
        Console.WriteLine(message);
    }

    private static void ShowCartInfo(ICart cart)
    {
        string message = "";

        if (cart.GetPurchases().Count > 0) {
            foreach (KeyValuePair<string, int> kind in cart.GetPurchases())
            {
                message += $"Название товара: {kind.Key}\n" +
                           $"В наличии шт.: {kind.Value}\n";

            }
        } else
        {
            message = "Вы пока что не совершили ни одной покупки";
        }
        
        Console.WriteLine(message);
    }
}
