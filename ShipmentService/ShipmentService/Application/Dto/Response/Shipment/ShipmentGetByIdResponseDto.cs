namespace Dto.Response.Shipment
{
    public class ShipmentGetByIdResponseDto
    {
        public int id { get; set; }
        public string address { get; set; } = string.Empty;
        public int orderId { get; set; }
    }
}
