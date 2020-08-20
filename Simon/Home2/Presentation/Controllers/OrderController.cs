using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using DomainLogics.DomainServices.Interface;
using DomainLogics.Models;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderDomainService orderDomainService;

        public OrderController(IOrderDomainService orderDomainService)
        {
            this.orderDomainService = orderDomainService;
        }

        public JsonResult AllBookOrder()
        {
            var allBookOrders = orderDomainService.AllBookOrder();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BookOrder, ModelsViewOrder>()
             .ForMember("BookTitle", opt => opt.MapFrom(c => c.Book.BookTitle)));
            var map = new Mapper(config);
            var orders = map.Map<List<BookOrder>, List<ModelsViewOrder>>(allBookOrders);


            return Json(orders, JsonRequestBehavior.AllowGet);
        }

        public JsonResult BookOrdersToday()
        {
            var bookOrderToday = orderDomainService.BookOrdersToday();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BookOrder, ModelsViewOrder>()
            .ForMember("BookTitle", opt => opt.MapFrom(c => c.Book.BookTitle)));
            var map = new Mapper(config);
            var ordersToday = map.Map<List<BookOrder>, List<ModelsViewOrder>>(bookOrderToday);


            return Json(ordersToday, JsonRequestBehavior.AllowGet);
        }
     
    }
}