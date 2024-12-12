using console_store.Objects;

namespace console_store.Repositories;

interface IProductsRepository
{
    public List<IProduct> GetProducts();
}