using DomainService.Abstract;
using DomainService.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DomainService.Extensions
{
    public static class DomainServiceExtensions
    {
        public static IServiceCollection LoadDomainServiceExtensions(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
