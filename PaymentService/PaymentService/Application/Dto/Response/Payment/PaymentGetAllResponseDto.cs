namespace Dto.Response.Payment
{
    public class PaymentGetAllResponseDto
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public bool isSuccess { get; set; }
    }
}
