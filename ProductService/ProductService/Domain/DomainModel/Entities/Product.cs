using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel.Entities
{
    [Table("Products")]
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
