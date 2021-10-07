using JoesPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoesPizza.Data.Services
{
    public interface IProductsService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task<Product> UpdateAsync(int id, Product newProduct);
        Task DeleteAsync(int id);
    }
}
