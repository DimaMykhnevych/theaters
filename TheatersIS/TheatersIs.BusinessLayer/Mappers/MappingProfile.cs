using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIS.DataLayer.Entities;

namespace TheatersIs.BusinessLayer.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Address, AddressDTO>().ReverseMap();
            CreateMap<Theater, TheaterDTO>().ReverseMap();
        }

    }
}
