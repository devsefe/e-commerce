using FluentValidation;

namespace Dto.Request.Payment
{
    public class PaymentUpdateRequestDto
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public bool isSuccess { get; set; }
    }

    public class PaymentUpdateRequestDtoValidator : AbstractValidator<PaymentUpdateRequestDto>
    {
        public PaymentUpdateRequestDtoValidator()
        {
            RuleFor(dto => dto.id)
                .NotEmpty().WithMessage("Ürün kimliği belirtilmelidir.")
                .GreaterThan(0).WithMessage("Geçersiz ürün kimliği.");

            RuleFor(dto => dto.orderId)
                .NotEmpty().WithMessage("Sipariş kimliği belirtilmelidir.")
                .GreaterThan(0).WithMessage("Geçersiz Sipariş kimliği.");

            RuleFor(dto => dto.price)
                .NotEmpty().WithMessage("Ürün fiyatı belirtilmelidir.")
                .GreaterThan(0).WithMessage("Ürün fiyatı pozitif bir değer olmalıdır.");

            RuleFor(dto => dto.quantity)
                .NotEmpty().WithMessage("Ürün miktarı belirtilmelidir.")
                .GreaterThan(0).WithMessage("Ürün miktarı pozitif bir değer olmalıdır.");
        }
    }
}
