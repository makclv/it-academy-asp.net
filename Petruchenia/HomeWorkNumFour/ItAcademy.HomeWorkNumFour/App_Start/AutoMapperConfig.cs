using AutoMapper;
using Domain.Entites;
using ItAcademy.HomeWorkNumFour.Models.CRUD;
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
            cfg.CreateMap<User, UserViewModel>();

            cfg.CreateMap<CreateUser, User>()
                .ForPath(x => x.Country.CountryId, u => u.MapFrom(x =>x.CountryId))
                .ForPath(x => x.Sity.SityId, u => u.MapFrom(x => x.SityId));

            cfg.CreateMap<User, EditUser>()
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country))
                .ForMember(dest => dest.Sity, opt => opt.MapFrom(src => src.Sity));
            cfg.CreateMap<EditUser, User>();

            cfg.CreateMap<User, DeleteUser>();
        }
    }
}