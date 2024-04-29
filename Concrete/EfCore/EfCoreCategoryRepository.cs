using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, ShopContext>, ICategoryRepository
    {
        public Category GetByIdWithProducts(int categoryId)
        {
            using (var context = new ShopContext()) 
            {
                return context.Categories
                                    .Where(i => i.CategoryId == categoryId)
                                    .Include(c => c.ProductCategories)
                                    .ThenInclude(p => p.Product)
                                    .FirstOrDefault();

            }
        }
    }
}