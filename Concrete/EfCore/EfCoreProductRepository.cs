using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, ShopContext>, IProductRepository
    {
        public List<Product> GetPopularProducts()
        {
            using (var context = new ShopContext()) 
            {
                return context.Products.ToList();
            }
        }

        public Product GetProductDetails(int id)
        {
            using (var context = new ShopContext()) 
            {
                return context.Products
                                    .Where(p => p.ProductId == id)
                                    .Include(p => p.ProductCategories)
                                    .ThenInclude(c => c.Category)
                                    .FirstOrDefault();
            }        
        }

        public List<Product> GetTop5Products()
        {
            throw new System.NotImplementedException();
        }
    }
}