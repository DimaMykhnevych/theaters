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
            CreateMap<Performance, PerformanceDTO>().ReverseMap();
            CreateMap<TheaterPerformance, TheaterPerformanceDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<Question, QuestionDTO>().ReverseMap();
            CreateMap<UserAnswer, UserAnswerDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Variant, VariantDTO>().ReverseMap();
        }

    }
}
