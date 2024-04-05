using DomainModel.Entities;

namespace DomainService.Abstract
{
    public interface IProductService
    {
        Task<Product> CreateAsync(Product entity);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task<Product> UpdateAsync(Product entity);
        Task DeleteAsync(Product entity);
    }
}
