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

            cfg.CreateMap<ViewCountry, Country>();
            cfg.CreateMap<ViewCity, City>();
            cfg.CreateMap<CreateUser, User>();
            cfg.CreateMap<EditUser, User>();
            cfg.CreateMap<User, EditUser>();

            cfg.CreateMap<User, DeleteUser>();
        }
    }
}