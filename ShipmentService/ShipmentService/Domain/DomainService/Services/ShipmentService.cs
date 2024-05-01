using DomainModel.Entities;
using DomainModel.Repository;
using DomainService.Abstract;

namespace DomainService.Services
{
    public class ShipmentService : IShipmentService
    {
        private readonly IRepository<Shipment> _repository;

        public ShipmentService(IRepository<Shipment> repository)
        {
            this._repository = repository;
        }

        public async Task<Shipment> CreateAsync(Shipment entity)
        {
            await _repository.CreateAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<Shipment>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Shipment?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Shipment> UpdateAsync(Shipment entity)
        {
            await _repository.UpdateAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(Shipment entity)
        {
            await _repository.DeleteAsync(entity);
        }
    }
}
