using DomainModel.Entities;
using DomainModel.Repository;
using DomainService.Abstract;

namespace DomainService.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IRepository<Payment> _repository;

        public PaymentService(IRepository<Payment> repository)
        {
            this._repository = repository;
        }

        public async Task<Payment> CreateAsync(Payment entity)
        {
            await _repository.CreateAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<Payment>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Payment?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Payment> UpdateAsync(Payment entity)
        {
            await _repository.UpdateAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(Payment entity)
        {
            await _repository.DeleteAsync(entity);
        }
    }
}
