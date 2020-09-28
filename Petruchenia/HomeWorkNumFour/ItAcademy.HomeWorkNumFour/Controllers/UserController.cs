using AutoMapper;
using ClassLibrary1.Services.Interfaces;
using Domain.Entites;
using Domain.UnitOfWork;
using ItAcademy.HomeWorkNumFour.Models.CRUD;
using ItAcademy.HomeWorkNumFour.Models.EntityFramework;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ItAcademy.HomeWorkNumFour.Controllers
{
    public class UserController : Controller
    {
        private readonly ICountryDomainService countryDomainService;
        private readonly ISityDomainService sityDomainService;
        private readonly IUserDomainService userDomainService;
        private readonly IUnitOfWork unitOfWork;

        public UserController(
            ICountryDomainService countryDomainService,
            ISityDomainService sityDomainService,
            IUserDomainService userDomainService,
            IUnitOfWork unitOfWork
            )
        {
            this.countryDomainService = countryDomainService;
            this.sityDomainService = sityDomainService;
            this.userDomainService = userDomainService;
            this.unitOfWork = unitOfWork;
        }

        public UserController()
        {

        }

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            CreateUser createUser = new CreateUser();
            createUser.CountriesDDL = countryDomainService.GetAllCountries();
            createUser.SitiesDDL = sityDomainService.GetAllSities();
            return View(createUser);
        }

        [HttpPost]
        public ActionResult Create(CreateUser createUser)
        {
            User user = Mapper.Map<CreateUser, User>(createUser);
            
            userDomainService.Create(user);
            unitOfWork.SaveChanges();
            return RedirectToAction("GetAllUsers");
        }

        [HttpGet]
        public ActionResult Edit (int Id)
        {
            EditUser editUser = Mapper.Map<User, EditUser>
                (userDomainService.GetById(Id));

            editUser.CountriesDDL = countryDomainService.GetAllCountries();
            editUser.SitiesDDL = sityDomainService.GetAllSities();

            return View(editUser);
        }

        [HttpPost]
        public ActionResult Edit(CreateUser createUser)
        {
            userDomainService.EditUser(Mapper.Map<CreateUser, User>(createUser));
            unitOfWork.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult GetAllUsers ()
        {
            List<User> AllUsers = userDomainService.GetAll();
            List<UserViewModel> userViewModels = new List<UserViewModel>();
            foreach (var item in AllUsers)
            {
                userViewModels.Add(Mapper.Map<User, UserViewModel>(item));
            }
            return View(userViewModels);
        }

        [HttpGet]
        public ActionResult Delete (int id)
        {
            DeleteUser deleteUser = Mapper.Map<User, DeleteUser>
                (userDomainService.GetById(id));
            return View(deleteUser);
        }

        [HttpPost]
        public ActionResult Delete(DeleteUser deleteUser)
        {
            userDomainService.DeleteUser(deleteUser.UserId);
            unitOfWork.SaveChanges();
            return RedirectToAction("GetAllUsers");
        }
    }
}