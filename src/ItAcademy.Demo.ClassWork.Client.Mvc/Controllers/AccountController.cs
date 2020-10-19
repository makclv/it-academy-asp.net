using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ItAcademy.Demo.ClassWork.Client.Mvc.App_Start.Core;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.Security;
using ItAcademy.Demo.ClassWork.Domain.Entities.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
{
    public partial class AccountController : Controller
    {
        [HttpGet]
        public virtual ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            return View();
        }

        [HttpPost]
        public virtual ActionResult Login(string username, string password, string returnUrl)
        {
            // validate
            var userManager = HttpContext.GetOwinContext().GetUserManager<AppUserManager>();
            var authManager = HttpContext.GetOwinContext().Authentication;

            ApplicationUser user = userManager.Find(username, password);
            if (user != null)
            {
                var identity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authManager.SignIn(new AuthenticationProperties { IsPersistent = false }, identity);

                if (!string.IsNullOrWhiteSpace(returnUrl))
                {
                    return Redirect(returnUrl);
                }

                return RedirectToAction(MVC.Home.Index());
            }

            return View();
        }

        public ActionResult Register(string email, string password)
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<AppUserManager>();
            var newUser = new ApplicationUser
            {
                Email = email,
                UserName = email
            };

            userManager.Create(newUser, password);

            return Content("OK");
        }

        public virtual ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction(MVC.Home.Index());
        }
    }
}