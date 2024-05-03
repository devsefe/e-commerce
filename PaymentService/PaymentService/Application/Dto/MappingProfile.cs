using AutoMapper;
using DomainModel.Entities;
using Dto.Request.Payment;
using Dto.Response.Payment;

namespace Dto
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PaymentCreateRequestDto, Payment>();
            CreateMap<PaymentUpdateRequestDto, Payment>();
            CreateMap<Payment, PaymentGetAllResponseDto>();
            CreateMap<Payment, PaymentGetByIdResponseDto>();
        }
    }
}
