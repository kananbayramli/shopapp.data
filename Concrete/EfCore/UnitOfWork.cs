using shopapp.data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.data.Concrete.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopContext _context;

        public UnitOfWork(ShopContext context)
        {
            _context = context;
        }

        private EfCoreCartRepository _cartRepository;
        private EfCoreCategoryRepository _categoryRepository;
        private EfCoreProductRepository _productRepository;
        private EfCoreOrderRepository _orderRepository;


        public ICartRepository Carts => _cartRepository ?? new EfCoreCartRepository(_context);
        public ICategoryRepository Categories => _categoryRepository ?? new EfCoreCategoryRepository(_context);
        public IOrderRepository Orders => _orderRepository ?? new EfCoreOrderRepository(_context);
        public IProductRepository Products => _productRepository ?? new EfCoreProductRepository(_context);


        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
