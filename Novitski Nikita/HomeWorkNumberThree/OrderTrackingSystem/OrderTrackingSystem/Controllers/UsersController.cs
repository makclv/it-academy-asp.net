using OrderTrackingSystem.PresentationServices.Interfaces;
using OrderTrackingSystem.ViewModels.Users;
using System.Net;
using System.Web.Mvc;

namespace OrderTrackingSystem.Controllers
{
    public class UsersController : Controller
    {
        readonly IUsersPresentationServices presentationServices;
        public UsersController(IUsersPresentationServices presentationServices)
        {
            this.presentationServices = presentationServices;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(presentationServices.GetUsers());

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(presentationServices.GetCreateUsersVm());

        }

        [HttpPost]
        public ActionResult Create(CreateUsersViewModel userVm)
        {
            if (ModelState.IsValid)
            {
                presentationServices.AddUser(userVm);
                return RedirectToAction("Index");
            }
            
            return View(presentationServices.GetCreateUsersVm(userVm));

        }

        [HttpGet]
        public ActionResult Edit(int id)                        
        {
            return View(presentationServices.GetEditUsersVm(id));
                
        }

        [HttpPost]
        public ActionResult Edit(EditUsersViewModel userVm)
        {
            if (ModelState.IsValid)
            {
                presentationServices.EditUser(userVm);
                return RedirectToAction("Index");
            }

            return View(presentationServices.GetEditUsersVm(userVm));

        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            DeleteUsersViewModel userVm = presentationServices.GetDeleteUsersVm((int)id);
            return View(userVm);

        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                presentationServices.DeleteUser(id);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");

        }
    }
}