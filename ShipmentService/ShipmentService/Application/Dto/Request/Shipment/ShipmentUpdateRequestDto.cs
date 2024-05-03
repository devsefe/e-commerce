using FluentValidation;

namespace Dto.Request.Shipment
{
    public class ShipmentUpdateRequestDto
    {
        public int id { get; set; }
        public string address { get; set; } = string.Empty;
        public int orderId { get; set; }
    }

    public class ShipmentUpdateRequestDtoValidator : AbstractValidator<ShipmentUpdateRequestDto>
    {
        public ShipmentUpdateRequestDtoValidator()
        {
            /*RuleFor(dto => dto.id)
                .NotEmpty().WithMessage("Ürün kimliği belirtilmelidir.")
                .GreaterThan(0).WithMessage("Geçersiz ürün kimliği.");

            RuleFor(dto => dto.name)
                .NotEmpty().WithMessage("Ürün adı boş olamaz.")
                .MaximumLength(50).WithMessage("Ürün adı en fazla 50 karakter olmalıdır.");

            RuleFor(dto => dto.price)
                .NotEmpty().WithMessage("Ürün fiyatı belirtilmelidir.")
                .GreaterThan(0).WithMessage("Ürün fiyatı pozitif bir değer olmalıdır.");

            RuleFor(dto => dto.quantity)
                .NotEmpty().WithMessage("Ürün miktarı belirtilmelidir.")
                .GreaterThan(0).WithMessage("Ürün miktarı pozitif bir değer olmalıdır.");*/
        }
    }
}
