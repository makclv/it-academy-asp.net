using AutoMapper;
using Data.Context;
using Data.Repositories;
using Data.UnitOfWork;
using ItAcademy.HomeWorkNumFour.MyMapper;
using ItAcademy.HomeWorkNumFour.Models.EntityFramework;
using System.Web.Mvc;
using Domain.Entites;
using ClassLibrary1.Services;

namespace ItAcademy.HomeWorkNumFour.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            using (var db = new CoreDbContext())
            {
                var uow = new UnitOfWork(db) { };
                var userRepository = new UserRepository(uow);
                UserDomainService userDomainService = new UserDomainService(userRepository, uow);

                var user = new User()
                {
                    FName = "Lesha",
                    LName = "Alex",
                    Phone = "+88005553535",
                    Email = "LexaPet@gmail.com",
                    Title = Title.Mr,
                    Country = new Country
                    {
                        CountryName = "asdasd"
                    },

                    Sity = new Sity
                    {
                        SityName = "asdads"
                    },

                    Comment = ""
                };

                //UserMapper userMapper = new UserMapper();
                //var user = userMapper.UserViewModelToUser(userToDb);

                //var config = new MapperConfiguration(cfg => cfg.CreateMap<UserViewModel, User>()
                //     .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                //     .ForMember(dest => dest.Sity, opt => opt.MapFrom(src => src.Sity.SityName))
                //     .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country.CountryName))
                //    );
                //var mapper = new Mapper(config);
                //User user = mapper.Map<UserViewModel, User>(userToDb);

                userDomainService.AddUser(user);
                uow.SaveChanges();
            }
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}