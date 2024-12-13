using console_store.Objects;

namespace console_store.Servicers;

public class MessagesService
{
    public static void ShowAvailableProducts(List<IProduct> products)
    {
        string message = "Товары в наличии:\n";
        
        foreach (IProduct product in products)
        {
            message += $"\nНазвание товара: {product.GetName()} (ID: {product.GetId()})\n" +
                       $"Цена товара: {product.GetPrice()} usd\n";
            
        }
        
        Console.WriteLine(message);
    }

    public static void ShowCustomerBalance(ICustomer customer)
    {
        string message = $"\nВаш баланс: {customer.GetBalance()}";
            
        Console.WriteLine(message);
    }

    public static void ShowCartInfo(ICart cart)
    {
        string message = "";

        if (cart.GetPurchases().Count > 0) {
            foreach (KeyValuePair<string, int> kind in cart.GetPurchases())
            {
                message += $"\nНазвание товара: {kind.Key}\n" +
                           $"В наличии шт.: {kind.Value}";

            }
        } else
        {
            message = "Вы пока что не совершили ни одной покупки";
        }
        
        Console.WriteLine(message);
    }

    public static void ShowInstructions()
    {
        var message = "Для покупки товара укажите его ID. Для завершения работы программы укажите \"0\"";
        
        Console.WriteLine(message);
    }
}