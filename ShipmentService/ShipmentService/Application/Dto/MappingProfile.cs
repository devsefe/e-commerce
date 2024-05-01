using AutoMapper;
using DomainModel.Entities;
using Dto.Request.Shipment;
using Dto.Response.Shipment;

namespace Dto
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ShipmentCreateRequestDto, Shipment>();
            CreateMap<ShipmentUpdateRequestDto, Shipment>();
            CreateMap<Shipment, ShipmentGetAllResponseDto>();
            CreateMap<Shipment, ShipmentGetByIdResponseDto>();
        }
    }
}
