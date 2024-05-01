using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel.Entities
{
    [Table("Orders")]
    public class Order : BaseEntity
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; } = string.Empty;
    }
}
