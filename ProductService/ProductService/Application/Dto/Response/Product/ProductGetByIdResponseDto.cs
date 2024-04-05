namespace Dto.Response.Product
{
    public class ProductGetByIdResponseDto
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public double price { get; set; }
        public int quantity { get; set; }
    }
}
