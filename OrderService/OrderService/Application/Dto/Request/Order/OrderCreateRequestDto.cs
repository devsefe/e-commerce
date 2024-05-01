using FluentValidation;

namespace Dto.Request.Order
{
    public class OrderCreateRequestDto
    {
        public int productId { get; set; }
        public int quantity { get; set; }
        public string address { get; set; } = string.Empty;
    }

    public class OrderCreateRequestDtoValidator : AbstractValidator<OrderCreateRequestDto>
    {
        public OrderCreateRequestDtoValidator()
        {
            RuleFor(dto => dto.productId)
                .NotEmpty().WithMessage("Ürün kimliği belirtilmelidir.")
                .GreaterThan(0).WithMessage("Geçersiz Ürün kimliği.");

            RuleFor(dto => dto.quantity)
                .NotEmpty().WithMessage("Ürün miktarı belirtilmelidir.")
                .GreaterThan(0).WithMessage("Ürün miktarı pozitif bir değer olmalıdır.");

            RuleFor(dto => dto.address)
                .NotEmpty().WithMessage("Adres boş olamaz.")
                .MaximumLength(100).WithMessage("Adres en fazla 100 karakter olmalıdır.");
        }
    }
}
