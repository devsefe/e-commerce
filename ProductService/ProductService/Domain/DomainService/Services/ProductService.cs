using DomainModel.Entities;
using DomainModel.Repository;
using DomainService.Abstract;

namespace DomainService.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            this._repository = repository;
        }

        public async Task<Product> CreateAsync(Product entity)
        {
            await _repository.CreateAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Product> UpdateAsync(Product entity)
        {
            await _repository.UpdateAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(Product entity)
        {
            await _repository.DeleteAsync(entity);
        }
    }
}
