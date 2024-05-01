using DomainModel.Entities;

namespace DomainService.Abstract
{
    public interface IShipmentService
    {
        Task<Shipment> CreateAsync(Shipment entity);
        Task<IEnumerable<Shipment>> GetAllAsync();
        Task<Shipment?> GetByIdAsync(int id);
        Task<Shipment> UpdateAsync(Shipment entity);
        Task DeleteAsync(Shipment entity);
    }
}
