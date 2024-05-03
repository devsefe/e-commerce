using Dto.Request.Shipment;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Dto.Extensions
{
    public static class DtoExtensions
    {
        public static IServiceCollection LoadDtoExtensions(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<ShipmentCreateRequestDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<ShipmentUpdateRequestDtoValidator>();
            return services;
        }
    }
}
