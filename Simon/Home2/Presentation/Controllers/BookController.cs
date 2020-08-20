using AutoMapper;
using DomainLogics.DomainServices;
using DomainLogics.DomainServices.Interface;
using DomainLogics.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookDomainService BookDomainService;
        
        public BookController(IBookDomainService bookDomainService)
        {
            this.BookDomainService = bookDomainService;
        }
        // GET: Book
        public ActionResult GetMostPopular()
        {
            var topFiveBook = BookDomainService.FiveMostPopularBooks();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book,ModelsViewBook>());
            var map = new  Mapper(config);
            var books = map.Map<List<Book>,List<ModelsViewBook>>(topFiveBook);
           
            return Json(books, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAllBooks()
        {
            var ALlBooks = BookDomainService.AllBooks();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book, ModelsViewBook>());
            var map = new Mapper(config);
            var books = map.Map<List<Book>, List<ModelsViewBook>>(ALlBooks);

            return Json(books, JsonRequestBehavior.AllowGet);
        }


    }
}