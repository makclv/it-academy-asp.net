
using System.Web.Mvc;
using ItAcademy.Hw.Domain.DomainServices.Interfaces;
using ItAcademy.Hw.Domain.Models;
using ItAcademy.Hw.Client.Models;
using AutoMapper;

namespace ItAcademy.Hw.Client.Controllers
{
    public class HwController : Controller
    {
        private readonly IBookDomainService bookDomainService;

        public HwController(IBookDomainService bookDomainService)
        {
            this.bookDomainService = bookDomainService;
        }

        public JsonResult GetFivePopBooks()
        {
            var con = new MapperConfiguration(c => c.CreateMap<Book, BookView>());
            var map = new Mapper(con);
            Book[] bookData = bookDomainService.GetFivePopBooks();
            BookView[] bookView = map.Map<Book[], BookView[]>(bookData);


            return Json(bookView, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetBooks()
        {
            var con = new MapperConfiguration(c => c.CreateMap<Book, BookView>());
            var map = new Mapper(con);
            Book[] bookData = bookDomainService.GetBooks();
            BookView[] bookView = map.Map<Book[], BookView[]>(bookData);
            return Json(bookView, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetOrders()
        {
            var con = new MapperConfiguration(c => c.CreateMap<Order, OrderView>());
            var map = new Mapper(con);
            Order[] orderData = bookDomainService.GetOrders();
            OrderView[] orderView = map.Map<Order[], OrderView[]>(orderData);
            return Json(orderView, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTodaysOrders()
        {
            var con = new MapperConfiguration(c => c.CreateMap<Order, OrderView>());
            var map = new Mapper(con);
            Order[] orderData = bookDomainService.GetTodaysOrders();
            OrderView[] orderView = map.Map<Order[], OrderView[]>(orderData);
            return Json(orderView, JsonRequestBehavior.AllowGet);
        }

    }
}