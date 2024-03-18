using AutoMapper;
using Bank.Core.DTOs;
using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Appointment,AppointmentDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Official, OfficialDto>().ReverseMap();
        }
    }
}
