using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel.Entities
{
    [Table("Payments")]
    public class Payment : BaseEntity
    {
        public int OrderId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool IsSuccess { get; set; }
    }
}
