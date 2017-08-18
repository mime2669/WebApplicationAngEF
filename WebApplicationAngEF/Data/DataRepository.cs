using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationAngEF.Data
{
    public class DataRepository : IDataRepository
    {
        DataContext _ctx;

        public DataRepository(DataContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Product> GetProducts()
        {
            return _ctx.Products;
        }

        public IQueryable<Product> GetProductsByShop(int shopId)
        {
            return _ctx.Products.Where(r => r.Shops.Any(s => s.Id == shopId));
        }
    }
}