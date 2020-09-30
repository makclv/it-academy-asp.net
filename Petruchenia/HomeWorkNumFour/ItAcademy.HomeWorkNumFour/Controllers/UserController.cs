using AutoMapper;
using ClassLibrary1.Services.Interfaces;
using Domain.Entites;
using Domain.UnitOfWork;
using ItAcademy.HomeWorkNumFour.Models.CRUD;
using ItAcademy.HomeWorkNumFour.Models.EntityFramework;
using ItAcademy.HomeWorkNumFour.Service.Interface;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ItAcademy.HomeWorkNumFour.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserPresentationService userPresentationService;
        
        public UserController(IUserPresentationService userPresentationService)
        {            
            this.userPresentationService = userPresentationService;
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
            return View(userPresentationService.AddToView());
        }

        [HttpPost]
        public ActionResult Create(CreateUser createUser)
        {
            if (!ModelState.IsValid)
            {
                createUser = userPresentationService.AddToView();
                return View("Create", createUser);
            }

            userPresentationService.AddToDb(createUser);

            return RedirectToAction("GetAllUsers");               
        }

        [HttpGet]
        public ActionResult Edit (int id)
        {            

            return View(userPresentationService.EditToView(id));
        }

        [HttpPost]
        public ActionResult Edit(EditUser editUser )
        {
            if (!ModelState.IsValid)
            {
                editUser = userPresentationService.EditToView(editUser.UserId);
                return View("Edit", editUser);
            }
                userPresentationService.EditToDb(editUser);
                return RedirectToAction("GetAllUsers");            
        }

        [HttpGet]
        public ActionResult GetAllUsers ()
        {
            List<UserViewModel> userViewModels = userPresentationService.GetUsersViewList();
            return View(userViewModels);
        }

        [HttpGet]
        public ActionResult Delete (int id)
        {
            return View(userPresentationService.GetUserByIdToDelete(id));
        }

        [HttpPost]
        public ActionResult Delete(DeleteUser deleteUser)
        {
            userPresentationService.DeleteUserById(deleteUser.UserId);
            return RedirectToAction("GetAllUsers");
        }
    }
}