using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Products> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Products>> GetProductsAsync();
        Task<IReadOnlyList<ProductBrand>> GetProductsBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetProductsTypesAsync();
    }
}
