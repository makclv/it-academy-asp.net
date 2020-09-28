using AutoMapper;
using Data.Context;
using Data.Repositories;
using Data.UnitOfWork;
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