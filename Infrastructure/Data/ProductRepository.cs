using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _db;

        public ProductRepository(StoreContext db)
        {
            _db = db;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _db.Products.Where(p => p.Id == id)
                .Include(p => p.ProductVariations).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _db.Products.ToListAsync();
        }

        public async Task<IReadOnlyList<ProductVariation>> GetProductVariationsAsync()
        {
            return await _db.ProductVariations.ToListAsync();
        }

        public async Task<IReadOnlyList<Core.Entities.Attribute>> GetVariationsAsync()
        {
            return await _db.Attributes.ToListAsync();
        }
    }
}
