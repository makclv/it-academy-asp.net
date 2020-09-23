using AutoMapper;
using HomeTask.Models;
using HomeTask.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeTask.MappingProfile
{
    public class MappingProfiles : Profile
    {
        public IMapper _mapper { get; set; }
        public MappingProfiles()
        {


            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserViewModel, User>()
                       .ForMember("FirstName", opt => opt.MapFrom(c => c.FullName.Split(' ')[0]))
                       .ForMember("LastName", opt => opt.MapFrom(c => c.FullName.Split(' ')[1]));
                cfg.CreateMap<User, UserViewModel>()
                .ForMember("FullName", opt => opt.MapFrom(c => c.FirstName + " " + c.LastName));
            });
            _mapper = config.CreateMapper();
          
        }
    }
}