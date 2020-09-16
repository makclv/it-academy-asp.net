using System.Web.Mvc;
using ItAcademy.HomeWorkNumThree.Models;
using ItAcademy.HomeWorkNumThree.Halper;

namespace ItAcademy.HomeWorkNumThree.Controllers
{
    public class UserController : Controller
    {
        // GET: Users
        public ActionResult ShowAllUsers()
        {
            ViewBag.User = Helper.GetFromJson();
            return View();
        }
        [HttpGet]
        public ActionResult Edit(
            string FirstName,
            string LastName,
            string Country,
            string Sity,
            string Email
            )
        {
            User user = new User();
            user.FirstName = FirstName;
            user.LastName = LastName;
            user.Country = Country;
            user.Sity = Sity;
            user.Email = Email;
            ViewBag.User = user;
            return View();
        }

        [HttpPost]
        public ActionResult Edit(object obj)
        {
            User user = (User)obj;
            Helper.AddToJson(user);
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int i)
        {
            Helper.Delete(i);
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            SelectList titlesList = new SelectList(System.Enum.GetNames(typeof(Title)), "Title");
            ViewBag.Title = titlesList;

            return View();
        }

        [HttpPost]
        public ActionResult Create(User a)
        {
            Helper.AddToJson(a);

            ViewBag.User = Helper.GetFromJson();

            return View("~/Views/User/ShowAllUsers.cshtml");
        }
    }
}