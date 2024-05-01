using AutoMapper;
using DomainModel.Entities;
using Dto.Request.Order;
using Dto.Response.Order;

namespace Dto
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderCreateRequestDto, Order>();
            CreateMap<OrderUpdateRequestDto, Order>();
            CreateMap<Order, OrderGetAllResponseDto>();
            CreateMap<Order, OrderGetByIdResponseDto>();
        }
    }
}
