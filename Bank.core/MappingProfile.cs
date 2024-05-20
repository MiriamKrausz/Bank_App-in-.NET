using AutoMapper;
using Bank.Core.DTOs;
using Bank.Entities;

namespace Bank.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Appointment, AppointmentDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Official, OfficialDto>().ReverseMap();
        }
    }
}
