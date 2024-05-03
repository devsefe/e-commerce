namespace Dto.Response.Order
{
    public class OrderGetByIdResponseDto
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        public string address { get; set; } = string.Empty;
    }
}
