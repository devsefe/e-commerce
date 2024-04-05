using FluentValidation;

namespace Dto.Request.Product
{
    public class ProductUpdateRequestDto
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public double price { get; set; }
        public int quantity { get; set; }
    }

    public class ProductUpdateRequestDtoValidator : AbstractValidator<ProductUpdateRequestDto>
    {
        public ProductUpdateRequestDtoValidator()
        {
            RuleFor(dto => dto.id)
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
                .GreaterThan(0).WithMessage("Ürün miktarı pozitif bir değer olmalıdır.");
        }
    }
}
