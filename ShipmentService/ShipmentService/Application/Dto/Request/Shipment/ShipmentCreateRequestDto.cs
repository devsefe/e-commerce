using FluentValidation;

namespace Dto.Request.Shipment
{
    public class ShipmentCreateRequestDto
    {        
        public string address { get; set; } = string.Empty;
        public int orderId { get; set; }
    }

    public class ShipmentCreateRequestDtoValidator : AbstractValidator<ShipmentCreateRequestDto>
    {
        public ShipmentCreateRequestDtoValidator()
        {
            /*RuleFor(dto => dto.name)
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
