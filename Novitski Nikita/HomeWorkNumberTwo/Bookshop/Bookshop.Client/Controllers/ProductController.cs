using AutoMapper;
using Bookshop.Client.Models.Products.Queries;
using Bookshop.Domain.DomainServices.ProductDomainService.ProductInterfaces;
using Bookshop.Domain.Models.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Bookshop.Client.Controllers
{
    public class ProductController : Controller  
    {
        // GET: Product
        private readonly IBooksDomainService booksDomainService;

        public ProductController(IBooksDomainService booksDomainService)
        {
            this.booksDomainService = booksDomainService;
        }

        [HttpGet]
        public ActionResult GetAllBooks()
        {
            List<Book> books = booksDomainService.GetAllBooks();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<List<Book>, GetAllBooksVm>()  // used for mapping example
                    .ForMember(dest => dest.Books, opt => opt.MapFrom(c => c)));
            var mapper = new Mapper(config);

            var booksVm = mapper.Map<List<Book>, GetAllBooksVm>(books);
            
            return Json(booksVm, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetTopFiveBooks()
        {

            List<Book> books = booksDomainService.GetTopFiveBooks();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<List<Book>, GetTopFiveBooksVm>()  // used for mapping example
                    .ForMember(dest => dest.Books, opt => opt.MapFrom(c => c)));
            var mapper = new Mapper(config);

            var booksVm = mapper.Map<List<Book>, GetTopFiveBooksVm>(books);


            return Json(booksVm, JsonRequestBehavior.AllowGet);

        }

    }
}