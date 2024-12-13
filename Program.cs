using console_store.Objects;
using console_store.Repositories;
using console_store.Servicers;

namespace console_store;

class Program
{
    static void Main(string[] args)
    {
        IProductsRepository repository = GetRepository();
        List<IProduct> products = repository.GetProducts();
        ICustomer customer = new Customer();
        Cart cart = new Cart();
        
        MessagesService.ShowInstructions();
        MessagesService.ShowAvailableProducts(products);
        MessagesService.ShowCustomerBalance(customer);
        MessagesService.ShowCartInfo(cart);

        while (true)
        {
            string? input = Console.ReadLine();
            if (input == null) continue;
            
            int inputCode = int.Parse(input);
            if (inputCode == 0) return;

            try {
                IProduct? product = FindProductById(products, inputCode);

                if (product == null) {
                    throw new Exception($"Продукт с ID {inputCode} не найден");
                }
                    
                cart.BuyProduct(product, customer);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            } finally {
                MessagesService.ShowCustomerBalance(customer);
                MessagesService.ShowCartInfo(cart);
            }
        }
    }

    private static IProductsRepository GetRepository()
    {
        return new MemoryProductsRepository();
    }

    private static IProduct? FindProductById(List<IProduct> products, int productId)
    {
        return products.Find(product => product.GetId() == productId);
    }
}
