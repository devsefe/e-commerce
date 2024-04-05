using FluentValidation;

namespace Dto.Request.Product
{
    public class ProductCreateRequestDto
    {
        public string name { get; set; } = string.Empty;
        public double price { get; set; }
        public int quantity { get; set; }
    }

    public class ProductCreateRequestDtoValidator : AbstractValidator<ProductCreateRequestDto>
    {
        public ProductCreateRequestDtoValidator()
        {
            RuleFor(dto => dto.name)
                .NotEmpty().WithMessage("Ürün adı boş olamaz.")
                .MaximumLength(50).WithMessage("Ürün adı en fazla 50 karakter olmalıdır.");

            RuleFor(dto => dto.price)
            .NotEmpty().WithMessage("Ürün fiyatı belirtilmelidir.")
            .GreaterThan(0).WithMessage("Ürün fiyatı pozitif bir değer olmalıdır.");

            RuleFor(dto => dto.quantity)
                .NotEmpty().WithMessage("Ürün miktarı belirtilmelidir.")
                .GreaterThan(0).WithMessage("Ürün miktarı pozitif bir değer olmalıdır.");
        }
    }
}
