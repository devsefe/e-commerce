using DomainModel.Entities;

namespace DomainService.Abstract
{
    public interface IOrderService
    {
        Task<Order> CreateAsync(Order entity);
        Task<IEnumerable<Order>> GetAllAsync();
        Task<Order?> GetByIdAsync(int id);
        Task<Order> UpdateAsync(Order entity);
        Task DeleteAsync(Order entity);
    }
}
