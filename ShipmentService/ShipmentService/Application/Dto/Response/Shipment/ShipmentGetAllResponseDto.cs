namespace Dto.Response.Shipment
{
    public class ShipmentGetAllResponseDto
    {
        public int id { get; set; }
        public string address { get; set; } = string.Empty;
        public int orderId { get; set; }
    }
}
