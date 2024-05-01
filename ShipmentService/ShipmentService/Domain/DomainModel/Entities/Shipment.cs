using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel.Entities
{
    [Table("Shipments")]
    public class Shipment : BaseEntity
    {
        public string Address { get; set; } = string.Empty;        
        public int OrderId { get; set; }
    }
}
