using DomainModel.Entities;
using DomainModel.Repository;
using DomainService.Abstract;

namespace DomainService.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _repository;

        public OrderService(IRepository<Order> repository)
        {
            this._repository = repository;
        }

        public async Task<Order> CreateAsync(Order entity)
        {
            await _repository.CreateAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Order?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Order> UpdateAsync(Order entity)
        {
            await _repository.UpdateAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(Order entity)
        {
            await _repository.DeleteAsync(entity);
        }
    }
}
