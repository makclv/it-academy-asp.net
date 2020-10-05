using HW4.Client.Models.ViewModels;
using HW4.Client.PresentationServices.Interfaces;
using System.Web.Mvc;

namespace HW4.Client.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserPresentationService presentationService;

        public UserController(IUserPresentationService presentationService)
        {
            this.presentationService = presentationService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(presentationService.AllUsers());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(presentationService.CreateUserViewModel());
        }

        [HttpPost]
        public ActionResult Create(CreateUserViewModel user)
        {
            if (ModelState.IsValid)
            {
                presentationService.AddUser(user);
                return RedirectToAction("Index");
            }
            return View(presentationService.GetCreatedUserViewModel(user));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(presentationService.GetEditUserViewModel(id));
        }

        [HttpPost]
        public ActionResult Edit(EditUserViewModel user)
        {
            if (ModelState.IsValid)
            {
                presentationService.EditUser(user);
                return RedirectToAction("Index");
            }
            return View(presentationService.GetEditUserViewModel(user));
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            DeleteUserViewModel user = presentationService.GetDeleteUserView(id);
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                presentationService.DeleteUser(id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}