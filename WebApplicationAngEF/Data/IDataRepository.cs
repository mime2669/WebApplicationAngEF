using System.Linq;

namespace WebApplicationAngEF.Data
{
    public interface IDataRepository
    {
        IQueryable<Product> GetProducts();
        IQueryable<Product> GetProductsByShop(int shopId);
    }
}