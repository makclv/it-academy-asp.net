using Home.Users.Models;
using Home.Users.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.Users.Controllers
{
    public class UserController : Controller
    {
        UserRepository rep = new UserRepository();

        
        public ActionResult Index(string sortOrder)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.TitileSortParm = sortOrder == "Title" ? "title_desc" : "Title";
            ViewBag.CountrySortParm = sortOrder == "Country" ? "country_desc" : "Country";
            ViewBag.CitySortParm = sortOrder == "City" ? "city_desc" : "City";
            ViewBag.PhoneSortParm = sortOrder == "Phone" ? "phone_desc" : "Phone";
            ViewBag.EMailSortParm = sortOrder == "EMail" ? "email_desc" : "Email";
            IEnumerable<User> obj = rep.SelectAllUsers();

            switch (sortOrder)
            {
                case "email_desc":
                    obj = obj.OrderByDescending(s => s.Email);
                    break;
                case "Email":
                    obj = obj.OrderBy(s => s.Email);
                    break;
                case "phone_desc":
                    obj = obj.OrderByDescending(s => s.Phone);
                    break;
                case "Phone":
                    obj = obj.OrderBy(s => s.Phone);
                    break;
                case "city_desc":
                    obj = obj.OrderByDescending(s => s.City.Name);
                    break;
                case "City":
                    obj = obj.OrderBy(s => s.City.Name);
                    break;
                case "country_desc":
                    obj = obj.OrderByDescending(s => s.Country.Name);
                    break;
                case "Country":
                    obj = obj.OrderBy(s => s.Country.Name);
                    break;
                case "title_desc":
                    obj = obj.OrderByDescending(s => s.Title);
                    break;
                case "Title":
                    obj = obj.OrderBy(s => s.Title);
                    break;
                case "name_desc":
                    obj = obj.OrderByDescending(s => s.Name);
                    break;
                default:
                    obj = obj.OrderBy(s => s.Name);
                    break;
            }

                      
            return View(obj);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                user.UserID = rep.GetLastInsertedId() + 1;
                rep.InsertUser(user);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            User obj = rep.SelectUserById(id);
            return View(obj);
        }

                
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            try
            {
                rep.UpdateUser(user);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            User obj = rep.SelectUserById(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                rep.DeleteUser(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}