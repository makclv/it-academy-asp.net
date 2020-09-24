using AutoMapper;
using Domain.Entites;
using ItAcademy.HomeWorkNumFour.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItAcademy.HomeWorkNumFour.App_Start
{
    public static class AutoMapperConfig
    {        
        public static void Configure(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country.CountryName))
                .ForMember(dest => dest.Sity, opt => opt.MapFrom(src => src.Sity.SityName));
        }
    }
}