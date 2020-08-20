using ClassLibrary1;
using ClassLibrary1.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork02.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookDomainService bookDomainService;
        public BookController(IBookDomainService bookDomainService)
        {
            this.bookDomainService = bookDomainService;
        }

        // GET: Book
        public ActionResult Get5MostPopelar()
        {
            BookBll bookBll = bookDomainService.Get5MostPopular();

            //BookView - Mapper

            return View("BookView1");
        }

        public ActionResult ShowAllBooks()
        {
            BookBll bookBll = bookDomainService.ShowAllBooks();

            //BookView - Mapper

            return View("BookView3");
        }

        public ActionResult ShowAllOrders()
        {
            BookBll bookBll = bookDomainService.ShowAllOrders();

            //BookView - Mapper

            return View("BookView4");
        }

        public ActionResult ShowAllOrdersFromToday()
        {
            BookBll bookBll = bookDomainService.ShowAllOrdersFromToday();

            //BookView - Mapper

            return View("BookView5");
        }
    }
}
