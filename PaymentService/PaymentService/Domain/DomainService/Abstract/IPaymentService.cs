using DomainModel.Entities;

namespace DomainService.Abstract
{
    public interface IPaymentService
    {
        Task<Payment> CreateAsync(Payment entity);
        Task<IEnumerable<Payment>> GetAllAsync();
        Task<Payment?> GetByIdAsync(int id);
        Task<Payment> UpdateAsync(Payment entity);
        Task DeleteAsync(Payment entity);
    }
}
