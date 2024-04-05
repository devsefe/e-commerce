using AutoMapper;
using DomainModel.Entities;
using Dto.Request.Product;
using Dto.Response.Product;

namespace Dto
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductCreateRequestDto, Product>();
            CreateMap<ProductUpdateRequestDto, Product>();
            CreateMap<Product, ProductGetAllResponseDto>();
            CreateMap<Product, ProductGetByIdResponseDto>();
        }
    }
}
