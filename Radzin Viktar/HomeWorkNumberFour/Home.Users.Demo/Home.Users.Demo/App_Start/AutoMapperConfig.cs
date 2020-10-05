using AutoMapper;
using Home.Users.Demo.Domain.Entities;
using Home.Users.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Users.Demo.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<User, UserViewModel>()
                .ForMember(dist => dist.Country, opt => opt.MapFrom(src => src.Country))
                .ForMember(dist => dist.City, opt => opt.MapFrom(scr => scr.City))
                .ForMember(dist => dist.Title, opt => opt.MapFrom(scr => scr.Title)).ReverseMap();
            cfg.CreateMap<User, UserEditViewModel>()
                .ForMember(dist => dist.Country, opt => opt.MapFrom(src => src.Country))
                .ForMember(dist => dist.City, opt => opt.MapFrom(scr => scr.City))
                .ForMember(dist => dist.TitleView, opt => opt.MapFrom(scr => scr.Title)).ReverseMap();
            cfg.CreateMap<Country, CountryViewModel>().ReverseMap();
            cfg.CreateMap<City, CityViewModel>().ReverseMap();
            cfg.CreateMap<Title, TitleViewModel>().ReverseMap();
    
        }
    }
}