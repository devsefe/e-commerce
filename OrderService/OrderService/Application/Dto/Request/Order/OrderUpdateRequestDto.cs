using FluentValidation;

namespace Dto.Request.Order
{
    public class OrderUpdateRequestDto
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        public string address { get; set; } = string.Empty;
    }

    public class OrderUpdateRequestDtoValidator : AbstractValidator<OrderUpdateRequestDto>
    {
        public OrderUpdateRequestDtoValidator()
        {
            RuleFor(dto => dto.id)
                .NotEmpty().WithMessage("Sipariş kimliği belirtilmelidir.")
                .GreaterThan(0).WithMessage("Geçersiz Sipariş kimliği.");

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
