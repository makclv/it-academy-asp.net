using OrderTrackingSystem.Domain.DomainServices.Interfaces;
using OrderTrackingSystem.PresentationServices.Interfaces;
using OrderTrackingSystem.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace OrderTrackingSystem.Controllers
{
    public class UsersController : Controller
    {

        IUsersPresentationServices presentationServices;
        public UsersController(IUsersPresentationServices presentationServices)
        {
            this.presentationServices = presentationServices;
        }

       
        // GET: Users
        public ActionResult Index()
        {
            return View(presentationServices.GetUsers());
        }

        public ActionResult Create()
        {
            ViewBag.City = new SelectList(presentationServices.GetCitys(), "Id", "Name");
            ViewBag.Country = new SelectList(presentationServices.GetCountrys(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateUsersViewModel userVm)
        {
            presentationServices.AddUser(userVm);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (presentationServices.VerificationUserId((Guid)id))
            {
                EditUsersViewModel userVm = presentationServices.GetEditUsersVm((Guid)id);

                ViewBag.City = new SelectList(presentationServices.GetCitys(), "Id", "Name");
                ViewBag.Country = new SelectList(presentationServices.GetCountrys(), "Id", "Name");
                return View(userVm);
            }
            return HttpNotFound();
            
        }
        
        [HttpPost]
        public ActionResult Edit(EditUsersViewModel userVm)
        {
            if (ModelState.IsValid)
            {
                presentationServices.EditUser(userVm);
                return RedirectToAction("Index");
            }
            ViewBag.City = new SelectList(presentationServices.GetCitys(), "Id", "Name");
            ViewBag.Country = new SelectList(presentationServices.GetCountrys(), "Id", "Name");
            return View(userVm);
        }

        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (presentationServices.VerificationUserId((Guid)id))
            {
                DeleteUsersViewModel userVm = presentationServices.GetDeleteUsersVm((Guid)id);

                //ViewBag.City = new SelectList(presentationServices.GetCitys(), "Id", "Name");
                //ViewBag.Country = new SelectList(presentationServices.GetCountrys(), "Id", "Name");
                return View(userVm);
            }
            return HttpNotFound();
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
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