namespace Dto.Response.Order
{
    public class OrderGetAllResponseDto
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        public string address { get; set; } = string.Empty;
    }
}
