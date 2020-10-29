using AutoMapper;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.EntityFramework;
using ItAcademy.Demo.ClassWork.Domain.Entities;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configure(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Role.Name));
        }
    }
}